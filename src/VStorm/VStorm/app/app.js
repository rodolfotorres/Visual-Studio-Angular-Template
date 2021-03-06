﻿'use strict';
window.app = angular.module('vstorm', ['ngRoute', 'ngResource', 'breeze.angular']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/welcome', { templateUrl: 'app/welcome/welcome.html', controller: 'welcomeController' })
        .when('/values', { templateUrl: 'app/values/values.html', controller: 'valuesController' })
        .otherwise({ redirectTo: '/welcome' });
}])
    .controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
        $scope.$on('$routeChangeSuccess', function (e, current, previous) {
            $scope.activeViewPath = $location.path();
        });
    }]);

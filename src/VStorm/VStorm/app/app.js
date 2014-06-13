'use strict';
var app = angular.module('vstorm', ['ngRoute', 'vstorm.controllers']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/welcome', { templateUrl: 'app/view/welcome.html', controller: 'welcomeController' })
        .when('/welcome2', { templateUrl: 'home/welcome2', controller: 'welcomeController' })
        .otherwise({ redirectTo: '/welcome' });
}])
    .controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
        $scope.$on('$routeChangeSuccess', function (e, current, previous) {
            $scope.activeViewPath = $location.path();
        });
    }]);

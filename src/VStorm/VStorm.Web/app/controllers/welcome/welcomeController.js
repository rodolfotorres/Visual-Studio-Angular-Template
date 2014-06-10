'use strict';

var controllers = angular.module('vstorm.controllers', []);

controllers.controller('welcomeController', ['$scope', function ($scope) {
    $scope.vstormVersion = '0.1';
    $scope.contacts = [
        {
            description: 'Github',
            value: 'https://github.com/rodolfotorres'
        },
        {
            description: 'Linkedin',
            value: 'https://www.linkedin.com/pub/rodolfo-torres/4/616/a89'
        }
    ];
}]);
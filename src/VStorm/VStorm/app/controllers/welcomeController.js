'use strict';

window.app.controller('welcomeController', ['$scope', 'dataservice', function ($scope, dataservice) {
    $scope.vstormVersion = '0.1';
    $scope.contacts = [];

    dataservice.getContacts().then(function(data) {
        $scope.contacts = data.results;
        console.log($scope.contacts);
    });

    //$scope.contacts = [
    //    {
    //        description: 'Github',
    //        value: 'https://github.com/rodolfotorres'
    //    },
    //    {
    //        description: 'Linkedin',
    //        value: 'https://www.linkedin.com/pub/rodolfo-torres/4/616/a89'
    //    }
    //];


}]);
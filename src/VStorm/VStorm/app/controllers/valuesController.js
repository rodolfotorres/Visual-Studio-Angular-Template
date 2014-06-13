window.app.controller('valuesController', ['$scope', 'valuesService', function($scope, valuesService) {
    $scope.name = 'Values Controller';
    $scope.values = {};
    console.log(valuesService);
    valuesService.query(function(response) {
        $scope.values = response;
        console.log(response);
    });
}]);
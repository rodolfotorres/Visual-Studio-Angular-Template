window.app.factory('valuesService', ['$resource', function ($resource) {
    return  $resource('/api/values', {});
}]);
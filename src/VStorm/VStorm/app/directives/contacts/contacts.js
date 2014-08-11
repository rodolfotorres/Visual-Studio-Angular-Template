﻿'use strict';

window.app.directive("ehSimple", function() {
    return function(scope, element) {
        element.addClass("plain");
    }
});
window.app.directive('contacts', ['dataservice', function (dataservice) {
    return {
        restrict: 'A',
        templateUrl: '/app/directives/contacts/contacts.html'
    }
}]);
'use strict';

window.app.directive("ehSimple", function() {
    return function(scope, element) {
        element.addClass("plain");
    }
});
window.app.directive('contacts', function () {
    return {
        restrict: 'E',
        replace: 'true',
        templateUrl: '/app/directives/contacts/contacts.html'
    }
});
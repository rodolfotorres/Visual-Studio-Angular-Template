/// <reference path="../../../../Scripts/jasmine.js" />
/// <reference path="../../../../Scripts/angular.js" />
/// <reference path="../../../../Scripts/angular-mocks.js" />
/// <reference path="../../../../app/app.js" />
/// <reference path="../../../../app/controllers/welcome/welcomeController.js" />

'use strict';
describe('WelcomeController', function() {
    beforeEach(module('vstorm'));

    it('should have version', inject(function($controller) {
        var scope = {};
        var sut = $controller('welcomeController', { $scope: scope });

        expect(scope.vstormVersion).toBe('0.1');
    }));

    it('should have 2 contacts', inject(function($controller) {
        var scope = {};
        var sut = $controller('welcomeController', { $scope: scope });

        expect(scope.contacts.length).toBe(2);
    }));
})
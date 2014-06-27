/// <reference path="../../../Scripts/jasmine.js" />
/// <reference path="../../../Scripts/angular.js" />
/// <reference path="../../../Scripts/angular-route.js" />
/// <reference path="../../../Scripts/angular-resource.js" />
/// <reference path="../../../Scripts/angular-mocks.js" />
/// <reference path="../../../Scripts/breeze.debug.js" />
/// <reference path="../../../Scripts/breeze.angular.js" />
/// <reference path="../../../app/app.js" />
/// <reference path="../../../app/services/dataservice.js" />
/// <reference path="../../../app/controllers/welcomeController.js" />

'use strict';
describe('Directive: contacts', function () {
    var element;
    var $scope;
    beforeEach(module('vstorm'));
    beforeEach(inject(function ($compile, $rootScope) {
        $scope = $rootScope; 
        element = angular.element("<div eh-simple>{{3 + 2}}</div>");
        $compile(element)($rootScope);
    }));

    it('should equal 5', function() {
        $scope.$digest();
        expect(element.html()).toBe("5");
    });

    describe("ehSimple", function() {
        it("should add a class of plain", function () {
            expect(element.hasClass("plain")).toBe(true);
        });
    });
});
/// <reference path="../../_references.js" />

'use strict';
describe('Directive: eh-simple', function () {
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

//describe('Directive: contacts', function () {
//    var element;
//    var $scope;
//    beforeEach(module('vstorm'));
//    beforeEach(inject(function ($compile, $rootScope) {
//        $scope = $rootScope;
//        element = angular.element("<div contacts>{{3 + 2}}</div>");
//        $compile(element)($rootScope);
//    }));

//    it('should equal 5', function () {
//        $scope.$digest();
//        expect(element.html()).toBe("5");
//    });

//    describe("ehSimple", function () {
//        it("should add a class of plain", function () {
//            expect(element.hasClass("plain")).toBe(true);
//        });
//    });
//});
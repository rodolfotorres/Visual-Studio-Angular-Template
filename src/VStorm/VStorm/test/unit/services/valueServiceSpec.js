/// <reference path="../../../Scripts/jasmine.js" />
/// <reference path="../../../Scripts/angular.js" />
/// <reference path="../../../Scripts/angular-route.js" />
/// <reference path="../../../Scripts/angular-resource.js" />
/// <reference path="../../../Scripts/angular-mocks.js" />
/// <reference path="../../../Scripts/breeze.debug.js" />
/// <reference path="../../../Scripts/breeze.angular.js" />
/// <reference path="../../../app/app.js" />
/// <reference path="../../../app/services/valuesService.js" />

'use strict';
describe('Value Services', function () {
    var valuesService;
    beforeEach(function() {
        module('vstorm');
        inject(function (_valuesService_) {
            valuesService = _valuesService_;
        });
    });
    
    //// check to see if it has the expected function
    //it('should have an values function', function () {
    //    expect(angular.isFunction(valuesService.values)).toBe(true);
    //});

    it('service should return 2 values', function() {
        var result;
        valuesService.query(function(response) {
            result = response;
            expect(result.length).toBe(2);
        });
        
    });
});
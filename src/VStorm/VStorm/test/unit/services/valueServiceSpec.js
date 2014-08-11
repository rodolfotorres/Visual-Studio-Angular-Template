/// <reference path="../../_references.js" />

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
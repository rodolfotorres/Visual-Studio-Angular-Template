/// <reference path="~/Scripts/jasmine.js" />
/// <reference path="~/Scripts/angular.js" />
/// <reference path="~/Scripts/angular-mocks.js" />
/// <reference path="~/app/app.js" />
/// <reference path="~/app/controllers/welcome/welcomeController.js" />

describe('vstorm app', function () {
    describe('contact list', function() {
        beforeEach(function () {
            browser.get('../../app/partials/index.html');
        });

        it('should browse', function() {
            expect(1).toBe(1);
        });
    });
});
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var system_service_1 = require("./system.service");
describe('SystemService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [system_service_1.SystemService]
        });
    });
    it('should be created', testing_1.inject([system_service_1.SystemService], function (service) {
        expect(service).toBeTruthy();
    }));
});

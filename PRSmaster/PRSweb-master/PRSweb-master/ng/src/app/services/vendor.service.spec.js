"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var vendor_service_1 = require("./vendor.service");
describe('VendorService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [vendor_service_1.VendorService]
        });
    });
    it('should be created', testing_1.inject([vendor_service_1.VendorService], function (service) {
        expect(service).toBeTruthy();
    }));
});

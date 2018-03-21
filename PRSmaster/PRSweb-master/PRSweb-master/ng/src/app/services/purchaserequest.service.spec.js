"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var purchaserequest_service_1 = require("./purchaserequest.service");
describe('PurchaserequestService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [purchaserequest_service_1.PurchaserequestService]
        });
    });
    it('should be created', testing_1.inject([purchaserequest_service_1.PurchaserequestService], function (service) {
        expect(service).toBeTruthy();
    }));
});

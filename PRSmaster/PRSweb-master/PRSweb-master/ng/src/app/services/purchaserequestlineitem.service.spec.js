"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var purchaserequestlineitem_service_1 = require("./purchaserequestlineitem.service");
describe('PurchaserequestlineitemService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [purchaserequestlineitem_service_1.PurchaserequestlineitemService]
        });
    });
    it('should be created', testing_1.inject([purchaserequestlineitem_service_1.PurchaserequestlineitemService], function (service) {
        expect(service).toBeTruthy();
    }));
});

"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var purchaserequestlineitem_add_component_1 = require("./purchaserequestlineitem-add.component");
describe('PurchaserequestlineitemAddComponent', function () {
    var component;
    var fixture;
    beforeEach(testing_1.async(function () {
        testing_1.TestBed.configureTestingModule({
            declarations: [purchaserequestlineitem_add_component_1.PurchaserequestlineitemAddComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = testing_1.TestBed.createComponent(purchaserequestlineitem_add_component_1.PurchaserequestlineitemAddComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});

"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var PurchaseRequestLineItem_1 = require("../../models/PurchaseRequestLineItem");
var PurchaserequestlineitemAddComponent = /** @class */ (function () {
    function PurchaserequestlineitemAddComponent(SystemSvc, PurchaserequestSvc, ProductSvc, PurchaserequestlineitemSvc, router, route) {
        this.SystemSvc = SystemSvc;
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.ProductSvc = ProductSvc;
        this.PurchaserequestlineitemSvc = PurchaserequestlineitemSvc;
        this.router = router;
        this.route = route;
        this.purchaserequestlineitem = new PurchaseRequestLineItem_1.PurchaseRequestLineItem(0, 1, 0, 0);
    }
    PurchaserequestlineitemAddComponent.prototype.getProducts = function () {
        var _this = this;
        this.ProductSvc.list()
            .then(function (resp) {
            _this.products = resp;
            console.log(resp);
        });
    };
    PurchaserequestlineitemAddComponent.prototype.add = function () {
        var _this = this;
        this.purchaserequestlineitem.PurchaseRequestId = this.purchaserequest.ID;
        console.log(this.purchaserequestlineitem);
        this.PurchaserequestlineitemSvc.add(this.purchaserequestlineitem)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequestlineitems/" + _this.purchaserequest.ID]);
        });
    };
    PurchaserequestlineitemAddComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestSvc.get(params.get('id'));
        })
            .subscribe(function (purchaserequest) { return _this.purchaserequest = purchaserequest; });
        this.getProducts();
    };
    PurchaserequestlineitemAddComponent = __decorate([
        core_1.Component({
            selector: 'app-purchaserequestlineitem-add',
            templateUrl: './purchaserequestlineitem-add.component.html',
            styleUrls: ['./purchaserequestlineitem-add.component.css']
        })
    ], PurchaserequestlineitemAddComponent);
    return PurchaserequestlineitemAddComponent;
}());
exports.PurchaserequestlineitemAddComponent = PurchaserequestlineitemAddComponent;

"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
require("rxjs/add/operator/switchMap");
var PurchaserequestlineitemEditComponent = /** @class */ (function () {
    function PurchaserequestlineitemEditComponent(PurchaserequestSvc, ProductSvc, PurchaserequestlineitemSvc, route, router) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.ProductSvc = ProductSvc;
        this.PurchaserequestlineitemSvc = PurchaserequestlineitemSvc;
        this.route = route;
        this.router = router;
    }
    PurchaserequestlineitemEditComponent.prototype.getProducts = function () {
        var _this = this;
        this.ProductSvc.list()
            .then(function (resp) {
            _this.products = resp;
            console.log(resp);
        });
    };
    PurchaserequestlineitemEditComponent.prototype.update = function () {
        var _this = this;
        this.PurchaserequestlineitemSvc.change(this.purchaserequestlineitem).then(function (resp) {
            console.log(resp);
            _this.router.navigate(['/purchaserequestlineitems/' + _this.purchaserequestlineitem.PurchaseRequestId]);
        });
    };
    PurchaserequestlineitemEditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestlineitemSvc.get(params.get('id'));
        })
            .subscribe(function (purchaserequestlineitem) {
            return _this.purchaserequestlineitem = purchaserequestlineitem;
        });
        this.getProducts();
    };
    PurchaserequestlineitemEditComponent = __decorate([
        core_1.Component({
            selector: 'app-purchaserequestlineitem-edit',
            templateUrl: './purchaserequestlineitem-edit.component.html',
            styleUrls: ['./purchaserequestlineitem-edit.component.css']
        })
    ], PurchaserequestlineitemEditComponent);
    return PurchaserequestlineitemEditComponent;
}());
exports.PurchaserequestlineitemEditComponent = PurchaserequestlineitemEditComponent;

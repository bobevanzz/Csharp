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
var PurchaserequestlineitemDetailComponent = /** @class */ (function () {
    function PurchaserequestlineitemDetailComponent(PurchaserequestSvc, PurchaserequestlineitemSvc, router, route) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.PurchaserequestlineitemSvc = PurchaserequestlineitemSvc;
        this.router = router;
        this.route = route;
    }
    PurchaserequestlineitemDetailComponent.prototype.remove = function () {
        var _this = this;
        console.log("remove()");
        this.PurchaserequestlineitemSvc.remove(this.purchaserequestlineitem)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequestlineitems/" + _this.purchaserequestlineitem.PurchaseRequestId]);
        });
    };
    PurchaserequestlineitemDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestlineitemSvc.get(params.get('id'));
        })
            .subscribe(function (purchaserequestlineitem) {
            return _this.purchaserequestlineitem = purchaserequestlineitem;
        });
    };
    PurchaserequestlineitemDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-purchaserequestlineitem-detail',
            templateUrl: './purchaserequestlineitem-detail.component.html',
            styleUrls: ['./purchaserequestlineitem-detail.component.css']
        })
    ], PurchaserequestlineitemDetailComponent);
    return PurchaserequestlineitemDetailComponent;
}());
exports.PurchaserequestlineitemDetailComponent = PurchaserequestlineitemDetailComponent;

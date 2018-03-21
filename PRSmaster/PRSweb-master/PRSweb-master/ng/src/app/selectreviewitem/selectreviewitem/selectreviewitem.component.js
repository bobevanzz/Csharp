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
var SelectreviewitemComponent = /** @class */ (function () {
    function SelectreviewitemComponent(PurchaserequestSvc, PurchaserequestlineitemSvc, route, router) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.PurchaserequestlineitemSvc = PurchaserequestlineitemSvc;
        this.route = route;
        this.router = router;
    }
    SelectreviewitemComponent.prototype.approve = function () {
        var _this = this;
        this.purchaserequest = this.purchaseRequestAndLines.PurchaseRequest;
        this.purchaserequest.Status = "APPROVED";
        this.PurchaserequestSvc.change(this.purchaserequest)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequests"]);
        });
    };
    SelectreviewitemComponent.prototype.reject = function () {
        var _this = this;
        this.purchaserequest = this.purchaseRequestAndLines.PurchaseRequest;
        this.purchaserequest.Status = "REJECTED";
        this.PurchaserequestSvc.change(this.purchaserequest)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequests"]);
        });
    };
    SelectreviewitemComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestlineitemSvc.GetByPurchaseRequestId(params.get('id'));
        })
            .subscribe(function (purchaseRequestAndLines) { return _this.purchaseRequestAndLines = purchaseRequestAndLines; });
        //all the data is now in purchaseRequestAndLines
    };
    SelectreviewitemComponent = __decorate([
        core_1.Component({
            selector: 'app-selectreviewitem',
            templateUrl: './selectreviewitem.component.html',
            styleUrls: ['./selectreviewitem.component.css']
        })
    ], SelectreviewitemComponent);
    return SelectreviewitemComponent;
}());
exports.SelectreviewitemComponent = SelectreviewitemComponent;

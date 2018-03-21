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
var PurchaseDetailComponent = /** @class */ (function () {
    function PurchaseDetailComponent(PurchaserequestSvc, router, route) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.router = router;
        this.route = route;
    }
    PurchaseDetailComponent.prototype.remove = function () {
        var _this = this;
        console.log("remove()");
        this.PurchaserequestSvc.remove(this.purchaserequest)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequests"]);
        });
    };
    PurchaseDetailComponent.prototype.review = function () {
        var _this = this;
        if (this.purchaserequest.Total <= 50) {
            this.purchaserequest.Status = "APPROVED";
        }
        else {
            this.purchaserequest.Status = "REVIEW"; //sets purchaserequest status to review or approved
        }
        ;
        this.PurchaserequestSvc.change(this.purchaserequest) //calls the change in service
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequests"]); //navigates to the list component
        });
    };
    PurchaseDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestSvc.get(params.get('id'));
        })
            .subscribe(function (purchaserequest) { return _this.purchaserequest = purchaserequest; });
    };
    PurchaseDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-purchase-detail',
            templateUrl: './purchase-detail.component.html',
            styleUrls: ['./purchase-detail.component.css']
        })
    ], PurchaseDetailComponent);
    return PurchaseDetailComponent;
}());
exports.PurchaseDetailComponent = PurchaseDetailComponent;

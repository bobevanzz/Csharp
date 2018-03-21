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
var PurchaserequestEditComponent = /** @class */ (function () {
    function PurchaserequestEditComponent(PurchaserequestSvc, UserSvc, route, router) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.UserSvc = UserSvc;
        this.route = route;
        this.router = router;
    }
    PurchaserequestEditComponent.prototype.update = function () {
        var _this = this;
        this.PurchaserequestSvc.change(this.purchaserequest).then(function (resp) {
            console.log(resp);
            _this.router.navigate(['/purchaserequests']);
        });
    };
    PurchaserequestEditComponent.prototype.getUsers = function () {
        var _this = this;
        this.UserSvc.list().then(function (resp) { return _this.users = resp; });
    };
    PurchaserequestEditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.PurchaserequestSvc.get(params.get('id'));
        })
            .subscribe(function (purchaserequest) { return _this.purchaserequest = purchaserequest; });
        this.getUsers();
    };
    PurchaserequestEditComponent = __decorate([
        core_1.Component({
            selector: 'app-purchaserequest-edit',
            templateUrl: './purchaserequest-edit.component.html',
            styleUrls: ['./purchaserequest-edit.component.css']
        })
    ], PurchaserequestEditComponent);
    return PurchaserequestEditComponent;
}());
exports.PurchaserequestEditComponent = PurchaserequestEditComponent;

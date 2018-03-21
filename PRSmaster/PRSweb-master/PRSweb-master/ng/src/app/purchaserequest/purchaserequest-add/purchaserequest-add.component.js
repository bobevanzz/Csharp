"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var PurchaseRequest_1 = require("../../models/PurchaseRequest");
var PurchaserequestAddComponent = /** @class */ (function () {
    function PurchaserequestAddComponent(PurchaserequestSvc, SystemSvc, UserSvc, router) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.SystemSvc = SystemSvc;
        this.UserSvc = UserSvc;
        this.router = router;
        this.purchaserequest = new PurchaseRequest_1.PurchaseRequest(0, '', '', this.dateNeeded, '', 'NEW', 0, new Date(), 0); //these are defaults - what's going to come up on the screen
    }
    PurchaserequestAddComponent.prototype.setDateNeeded = function () {
        this.dateNeeded = new Date();
        this.dateNeeded.setDate(this.dateNeeded.getDate() + 7);
    };
    PurchaserequestAddComponent.prototype.add = function () {
        var _this = this;
        console.log(this.purchaserequest);
        this.PurchaserequestSvc.add(this.purchaserequest).then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/purchaserequests"]);
        });
    };
    PurchaserequestAddComponent.prototype.ngOnInit = function () {
        if (!this.SystemSvc.IsLoggedIn()) {
            this.router.navigateByUrl("/login");
        }
        this.loggedInUser = this.SystemSvc.getLoggedIn();
        console.log(this.loggedInUser);
        this.purchaserequest.UserId = this.loggedInUser.ID;
    };
    PurchaserequestAddComponent = __decorate([
        core_1.Component({
            selector: 'app-purchaserequest-add',
            templateUrl: './purchaserequest-add.component.html',
            // template: "<h1 *ngIf='loggedInUser'>{{loggedInUser.UserName}}</h1>",
            styleUrls: ['./purchaserequest-add.component.css']
        })
    ], PurchaserequestAddComponent);
    return PurchaserequestAddComponent;
}());
exports.PurchaserequestAddComponent = PurchaserequestAddComponent;

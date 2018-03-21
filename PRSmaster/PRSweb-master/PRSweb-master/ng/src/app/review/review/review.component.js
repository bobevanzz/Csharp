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
var ReviewComponent = /** @class */ (function () {
    function ReviewComponent(PurchaserequestSvc, router, route) {
        this.PurchaserequestSvc = PurchaserequestSvc;
        this.router = router;
        this.route = route;
    }
    ReviewComponent.prototype.review = function () {
        var _this = this;
        this.PurchaserequestSvc.review() //calls the change in service
            .then(function (resp) {
            console.log(resp);
            _this.purchaserequests = resp;
        });
    };
    ReviewComponent.prototype.ngOnInit = function () {
        this.review();
    };
    ReviewComponent = __decorate([
        core_1.Component({
            selector: 'app-review',
            templateUrl: './review.component.html',
            styleUrls: ['./review.component.css']
        })
    ], ReviewComponent);
    return ReviewComponent;
}());
exports.ReviewComponent = ReviewComponent;

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
var UserDetailComponent = /** @class */ (function () {
    function UserDetailComponent(UserSvc, router, route) {
        this.UserSvc = UserSvc;
        this.router = router;
        this.route = route;
    }
    UserDetailComponent.prototype.remove = function () {
        var _this = this;
        console.log("remove()");
        this.UserSvc.remove(this.user)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/users"]);
        });
    };
    UserDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.UserSvc.get(params.get('id'));
        })
            .subscribe(function (user) { return _this.user = user; });
    };
    UserDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-user-detail',
            templateUrl: './user-detail.component.html',
            styleUrls: ['./user-detail.component.css']
        })
    ], UserDetailComponent);
    return UserDetailComponent;
}());
exports.UserDetailComponent = UserDetailComponent;

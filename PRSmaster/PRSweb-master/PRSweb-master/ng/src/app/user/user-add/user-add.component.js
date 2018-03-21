"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var User_1 = require("../../models/User");
var UserAddComponent = /** @class */ (function () {
    function UserAddComponent(UserSvc, router) {
        this.UserSvc = UserSvc;
        this.router = router;
        this.user = new User_1.User(0, '', '', '', '', '', '', false, false); //these are defaults - what's going to come up on the screen
    }
    UserAddComponent.prototype.add = function () {
        var _this = this;
        this.UserSvc.add(this.user).then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/users"]);
        });
    };
    UserAddComponent.prototype.ngOnInit = function () {
    };
    UserAddComponent = __decorate([
        core_1.Component({
            selector: 'app-user-add',
            templateUrl: './user-add.component.html',
            styleUrls: ['./user-add.component.css']
        })
    ], UserAddComponent);
    return UserAddComponent;
}());
exports.UserAddComponent = UserAddComponent;

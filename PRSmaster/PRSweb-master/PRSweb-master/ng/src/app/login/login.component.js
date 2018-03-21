"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
require("rxjs/add/operator/toPromise");
var LoginComponent = /** @class */ (function () {
    function LoginComponent(UserSvc, router, SystemSvc) {
        this.UserSvc = UserSvc;
        this.router = router;
        this.SystemSvc = SystemSvc;
        this.username = "admin";
        this.password = "admin";
        this.message = " ";
    }
    LoginComponent.prototype.login = function () {
        var _this = this;
        this.message = "";
        this.UserSvc.login(this.username, this.password)
            .then(function (resp) { return _this.checkData(resp); });
        // let parms = "UserName=" + this.username + "&Password=" + this.password;
        //this.http.get("http://localhost:57177/Users/Login?" + parms) //this makes the call to the server and passes in the data when the user enters their username and password
        //.subscribe(data => { this.checkData(data); }); //data is then passed into the variable called data
    };
    LoginComponent.prototype.checkData = function (users) {
        if (users.length > 0) {
            this.user = users[0];
            this.SystemSvc.setLoggedIn(this.user);
            console.log("Set SystemSvc logged in user to ", this.SystemSvc.getLoggedIn());
            this.router.navigateByUrl("/home");
        }
        else {
            this.message = "USER NAME AND/OR PASSWORD NOT FOUND";
        }
    };
    LoginComponent.prototype.ngOnInit = function () {
        console.log("In LoginComponent");
    };
    LoginComponent = __decorate([
        core_1.Component({
            selector: 'app-login',
            templateUrl: './login.component.html',
            styleUrls: ['./login.component.css']
        })
    ], LoginComponent);
    return LoginComponent;
}());
exports.LoginComponent = LoginComponent;

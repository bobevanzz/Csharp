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
require("rxjs/add/operator/map");
var urlBase = 'http://localhost:57177/';
var mvcCtrl = 'Users/';
var url = urlBase + mvcCtrl;
var UserService = /** @class */ (function () {
    function UserService(http) {
        this.http = http;
    }
    UserService.prototype.login = function (username, password) {
        var parms = "UserName=" + username + "&Password=" + password;
        return this.http.get(url + 'Login?' + parms) //call to the server
            .toPromise() //turns the response into a formal promise
            .then(function (resp) { return resp.json(); }) //what to do with the response once it comes back
            .catch(this.handleError);
    };
    UserService.prototype.list = function () {
        return this.http.get(url + 'List')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    UserService.prototype.get = function (id) {
        return this.http.get(url + 'Get/' + id)
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    UserService.prototype.add = function (user) {
        return this.http.post(url + 'Add', user)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    UserService.prototype.change = function (user) {
        return this.http.post(url + 'Change', user)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    UserService.prototype.remove = function (user) {
        return this.http.post(url + 'Remove', user)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    //any error that generates from above will get passed into here:
    UserService.prototype.handleError = function (error) {
        console.error('An error has occurred', error);
        return Promise.reject(error.message || error); //reject means failed (so whatever user tried to do didn't work)
    };
    UserService = __decorate([
        core_1.Injectable()
    ], UserService);
    return UserService;
}());
exports.UserService = UserService;

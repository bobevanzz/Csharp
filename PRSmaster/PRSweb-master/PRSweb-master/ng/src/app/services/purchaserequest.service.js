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
var mvcCtrl = 'PurchaseRequests/';
var url = urlBase + mvcCtrl;
var PurchaserequestService = /** @class */ (function () {
    function PurchaserequestService(http) {
        this.http = http;
    }
    PurchaserequestService.prototype.list = function () {
        return this.http.get(url + 'List')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.get = function (id) {
        return this.http.get(url + 'Get/' + id)
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.add = function (purchaseRequest) {
        return this.http.post(url + 'Add', purchaseRequest)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.change = function (purchaseRequest) {
        return this.http.post(url + 'Change', purchaseRequest)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.remove = function (purchaseRequest) {
        return this.http.post(url + 'Remove', purchaseRequest)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.review = function () {
        return this.http.get(url + 'Review')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.accept = function () {
        return this.http.get(url + 'Accept')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestService.prototype.reject = function () {
        return this.http.get(url + 'Reject')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    //any error that generates from above will get passed into here:
    PurchaserequestService.prototype.handleError = function (error) {
        console.error('An error has occurred', error);
        return Promise.reject(error.message || error); //reject means failed (so whatever user tried to do didn't work)
    };
    PurchaserequestService = __decorate([
        core_1.Injectable()
    ], PurchaserequestService);
    return PurchaserequestService;
}());
exports.PurchaserequestService = PurchaserequestService;

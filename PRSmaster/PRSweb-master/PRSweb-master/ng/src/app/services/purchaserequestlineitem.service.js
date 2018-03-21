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
var mvcCtrl = 'PurchaseRequestLineItems/';
var url = urlBase + mvcCtrl;
var PurchaserequestlineitemService = /** @class */ (function () {
    function PurchaserequestlineitemService(http) {
        this.http = http;
    }
    PurchaserequestlineitemService.prototype.list = function () {
        return this.http.get(url + 'List')
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.get = function (id) {
        return this.http.get(url + 'Get/' + id)
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.add = function (purchaseRequestLineItem) {
        return this.http.post(url + 'Add', purchaseRequestLineItem)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.change = function (purchaseRequestLineItem) {
        return this.http.post(url + 'Change', purchaseRequestLineItem)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.remove = function (purchaseRequestLineItem) {
        return this.http.post(url + 'Remove', purchaseRequestLineItem)
            .toPromise()
            .then(function (resp) { return resp.json() || {}; })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.GetByPurchaseRequestId = function (id) {
        return this.http.get(url + 'GetByPurchaseRequestId/' + id)
            .toPromise()
            .then(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PurchaserequestlineitemService.prototype.handleError = function (error) {
        console.error('An error has occurred', error);
        return Promise.reject(error.message || error); //reject means failed (so whatever user tried to do didn't work)
    };
    PurchaserequestlineitemService = __decorate([
        core_1.Injectable()
    ], PurchaserequestlineitemService);
    return PurchaserequestlineitemService;
}());
exports.PurchaserequestlineitemService = PurchaserequestlineitemService;

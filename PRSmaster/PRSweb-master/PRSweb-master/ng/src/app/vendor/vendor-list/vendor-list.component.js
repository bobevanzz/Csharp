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
var VendorListComponent = /** @class */ (function () {
    function VendorListComponent(VendorSvc) {
        this.VendorSvc = VendorSvc;
    }
    VendorListComponent.prototype.getVendors = function () {
        var _this = this;
        this.VendorSvc.list()
            .then(function (resp) { return _this.vendors = resp; }); //array of users gets stored in this variable (resp)
    };
    VendorListComponent.prototype.ngOnInit = function () {
        this.getVendors();
    };
    VendorListComponent = __decorate([
        core_1.Component({
            selector: 'app-vendor-list',
            templateUrl: './vendor-list.component.html',
            styleUrls: ['./vendor-list.component.css']
        })
    ], VendorListComponent);
    return VendorListComponent;
}());
exports.VendorListComponent = VendorListComponent;

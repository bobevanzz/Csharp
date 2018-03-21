"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var Vendors_1 = require("../../models/Vendors");
var VendorAddComponent = /** @class */ (function () {
    function VendorAddComponent(VendorSvc, router) {
        this.VendorSvc = VendorSvc;
        this.router = router;
        this.vendor = new Vendors_1.Vendor(0, '', '', '', '', '', '', '', false); //these are defaults - what's going to come up on the screen
    }
    VendorAddComponent.prototype.add = function () {
        var _this = this;
        this.VendorSvc.add(this.vendor).then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/vendors"]);
        });
    };
    VendorAddComponent.prototype.ngOnInit = function () {
    };
    VendorAddComponent = __decorate([
        core_1.Component({
            selector: 'app-vendor-add',
            templateUrl: './vendor-add.component.html',
            styleUrls: ['./vendor-add.component.css']
        })
    ], VendorAddComponent);
    return VendorAddComponent;
}());
exports.VendorAddComponent = VendorAddComponent;

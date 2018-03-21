"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var Product_1 = require("../../models/Product");
var ProductAddComponent = /** @class */ (function () {
    function ProductAddComponent(ProductSvc, VendorSvc, router) {
        this.ProductSvc = ProductSvc;
        this.VendorSvc = VendorSvc;
        this.router = router;
        this.product = new Product_1.Product(0, '', '', 0, '', '', 0); //these are defaults - what's going to come up on the screen
    }
    ProductAddComponent.prototype.add = function () {
        var _this = this;
        this.ProductSvc.add(this.product).then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/products"]);
        });
    };
    ProductAddComponent.prototype.getVendors = function () {
        var _this = this;
        this.VendorSvc.list().then(function (resp) { return _this.vendors = resp; });
    };
    ProductAddComponent.prototype.ngOnInit = function () {
        this.getVendors();
    };
    ProductAddComponent = __decorate([
        core_1.Component({
            selector: 'app-product-add',
            templateUrl: './product-add.component.html',
            styleUrls: ['./product-add.component.css']
        })
    ], ProductAddComponent);
    return ProductAddComponent;
}());
exports.ProductAddComponent = ProductAddComponent;

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
var ProductEditComponent = /** @class */ (function () {
    function ProductEditComponent(ProductSvc, VendorSvc, route, router) {
        this.ProductSvc = ProductSvc;
        this.VendorSvc = VendorSvc;
        this.route = route;
        this.router = router;
    }
    ProductEditComponent.prototype.update = function () {
        var _this = this;
        this.ProductSvc.change(this.product).then(function (resp) {
            console.log(resp);
            _this.router.navigate(['/products']);
        });
    };
    ProductEditComponent.prototype.getVendors = function () {
        var _this = this;
        this.VendorSvc.list().then(function (resp) { return _this.vendors = resp; });
    };
    ProductEditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.ProductSvc.get(params.get('id'));
        })
            .subscribe(function (product) { return _this.product = product; });
        this.getVendors();
    };
    ProductEditComponent = __decorate([
        core_1.Component({
            selector: 'app-product-edit',
            templateUrl: './product-edit.component.html',
            styleUrls: ['./product-edit.component.css']
        })
    ], ProductEditComponent);
    return ProductEditComponent;
}());
exports.ProductEditComponent = ProductEditComponent;

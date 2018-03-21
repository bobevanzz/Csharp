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
var ProductDetailComponent = /** @class */ (function () {
    function ProductDetailComponent(ProductSvc, router, route) {
        this.ProductSvc = ProductSvc;
        this.router = router;
        this.route = route;
    }
    ProductDetailComponent.prototype.remove = function () {
        var _this = this;
        console.log("remove()");
        this.ProductSvc.remove(this.product)
            .then(function (resp) {
            console.log(resp);
            _this.router.navigate(["/products"]);
        });
    };
    ProductDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.ProductSvc.get(params.get('id'));
        })
            .subscribe(function (product) { return _this.product = product; });
    };
    ProductDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-product-detail',
            templateUrl: './product-detail.component.html',
            styleUrls: ['./product-detail.component.css']
        })
    ], ProductDetailComponent);
    return ProductDetailComponent;
}());
exports.ProductDetailComponent = ProductDetailComponent;

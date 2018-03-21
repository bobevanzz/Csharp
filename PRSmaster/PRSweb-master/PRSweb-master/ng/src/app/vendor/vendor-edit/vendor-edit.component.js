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
var VendorEditComponent = /** @class */ (function () {
    function VendorEditComponent(VendorSvc, route, router) {
        this.VendorSvc = VendorSvc;
        this.route = route;
        this.router = router;
    }
    VendorEditComponent.prototype.update = function () {
        var _this = this;
        this.VendorSvc.change(this.vendor).then(function (resp) {
            console.log(resp);
            _this.router.navigate(['/vendors']);
        });
    };
    VendorEditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.paramMap
            .switchMap(function (params) {
            return _this.VendorSvc.get(params.get('id'));
        })
            .subscribe(function (vendor) { return _this.vendor = vendor; });
    };
    VendorEditComponent = __decorate([
        core_1.Component({
            selector: 'app-vendor-edit',
            templateUrl: './vendor-edit.component.html',
            styleUrls: ['./vendor-edit.component.css']
        })
    ], VendorEditComponent);
    return VendorEditComponent;
}());
exports.VendorEditComponent = VendorEditComponent;

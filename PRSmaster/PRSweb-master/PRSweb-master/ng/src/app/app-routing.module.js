"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var home_component_1 = require("./home/home.component");
var about_component_1 = require("./about/about.component");
var contact_component_1 = require("./contact/contact.component");
var help_component_1 = require("./help/help.component");
var login_component_1 = require("./login/login.component");
var user_list_component_1 = require("./user/user-list/user-list.component");
var user_detail_component_1 = require("./user/user-detail/user-detail.component");
var user_edit_component_1 = require("./user/user-edit/user-edit.component");
var user_add_component_1 = require("./user/user-add/user-add.component");
var vendor_list_component_1 = require("./vendor/vendor-list/vendor-list.component");
var vendor_detail_component_1 = require("./vendor/vendor-detail/vendor-detail.component");
var vendor_add_component_1 = require("./vendor/vendor-add/vendor-add.component");
var vendor_edit_component_1 = require("./vendor/vendor-edit/vendor-edit.component");
var product_list_component_1 = require("./product/product-list/product-list.component");
var product_detail_component_1 = require("./product/product-detail/product-detail.component");
var product_add_component_1 = require("./product/product-add/product-add.component");
var product_edit_component_1 = require("./product/product-edit/product-edit.component");
var purchaserequest_list_component_1 = require("./purchaserequest/purchaserequest-list/purchaserequest-list.component");
var purchase_detail_component_1 = require("./purchaserequest/purchase-detail/purchase-detail.component");
var purchaserequest_add_component_1 = require("./purchaserequest/purchaserequest-add/purchaserequest-add.component");
var purchaserequest_edit_component_1 = require("./purchaserequest/purchaserequest-edit/purchaserequest-edit.component");
var review_component_1 = require("./review/review/review.component");
var purchaserequestlineitem_list_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-list/purchaserequestlineitem-list.component");
var purchaserequestlineitem_add_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-add/purchaserequestlineitem-add.component");
var purchaserequestlineitem_detail_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-detail/purchaserequestlineitem-detail.component");
var purchaserequestlineitem_edit_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-edit/purchaserequestlineitem-edit.component");
var selectreviewitem_component_1 = require("./selectreviewitem/selectreviewitem/selectreviewitem.component");
var routes = [
    { path: "", redirectTo: "/home", pathMatch: "full" },
    { path: "home", component: home_component_1.HomeComponent },
    { path: "login", component: login_component_1.LoginComponent },
    { path: "users", component: user_list_component_1.UserListComponent },
    { path: "users/detail/:id", component: user_detail_component_1.UserDetailComponent },
    { path: "users/edit/:id", component: user_edit_component_1.UserEditComponent },
    { path: "users/add", component: user_add_component_1.UserAddComponent },
    { path: "about", component: about_component_1.AboutComponent },
    { path: "contact", component: contact_component_1.ContactComponent },
    { path: "help", component: help_component_1.HelpComponent },
    { path: "vendors", component: vendor_list_component_1.VendorListComponent },
    { path: "vendors/detail/:id", component: vendor_detail_component_1.VendorDetailComponent },
    { path: "vendors/add", component: vendor_add_component_1.VendorAddComponent },
    { path: "vendors/edit/:id", component: vendor_edit_component_1.VendorEditComponent },
    { path: "products", component: product_list_component_1.ProductListComponent },
    { path: "products/detail/:id", component: product_detail_component_1.ProductDetailComponent },
    { path: "products/add", component: product_add_component_1.ProductAddComponent },
    { path: "products/edit/:id", component: product_edit_component_1.ProductEditComponent },
    { path: "purchaserequests", component: purchaserequest_list_component_1.PurchaserequestListComponent },
    { path: "purchaserequests/detail/:id", component: purchase_detail_component_1.PurchaseDetailComponent },
    { path: "purchaserequests/add", component: purchaserequest_add_component_1.PurchaserequestAddComponent },
    { path: "purchaserequests/edit/:id", component: purchaserequest_edit_component_1.PurchaserequestEditComponent },
    { path: "review", component: review_component_1.ReviewComponent },
    { path: "purchaserequestlineitems/:id", component: purchaserequestlineitem_list_component_1.PurchaserequestlineitemListComponent },
    { path: "purchaserequestlineitems/add/:id", component: purchaserequestlineitem_add_component_1.PurchaserequestlineitemAddComponent },
    { path: "purchaserequestlineitems/detail/:id", component: purchaserequestlineitem_detail_component_1.PurchaserequestlineitemDetailComponent },
    { path: "purchaserequestlineitems/edit/:id", component: purchaserequestlineitem_edit_component_1.PurchaserequestlineitemEditComponent },
    { path: "selectreviewitem/:id", component: selectreviewitem_component_1.SelectreviewitemComponent }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        core_1.NgModule({
            imports: [router_1.RouterModule.forRoot(routes)],
            exports: [router_1.RouterModule]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());
exports.AppRoutingModule = AppRoutingModule;

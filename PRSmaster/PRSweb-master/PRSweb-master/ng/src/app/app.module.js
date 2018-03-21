"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser"); //imports are Javascript
var core_1 = require("@angular/core"); //data inside the curly braces is the class name; from  - file name (like the references)
// the things you need from Angular will be in the @angular files
var http_1 = require("@angular/http"); //allows us to make AJAX calls
var forms_1 = require("@angular/forms");
var app_routing_module_1 = require("./app-routing.module");
var app_component_1 = require("./app.component");
var menu_component_1 = require("./menu/menu.component");
var heading_component_1 = require("./heading/heading.component");
var home_component_1 = require("./home/home.component");
var about_component_1 = require("./about/about.component");
var contact_component_1 = require("./contact/contact.component");
var help_component_1 = require("./help/help.component");
var login_component_1 = require("./login/login.component");
var user_service_1 = require("./services/user.service");
var user_list_component_1 = require("./user/user-list/user-list.component");
var user_detail_component_1 = require("./user/user-detail/user-detail.component");
var user_edit_component_1 = require("./user/user-edit/user-edit.component");
var user_add_component_1 = require("./user/user-add/user-add.component");
var vendor_service_1 = require("./services/vendor.service");
var vendor_list_component_1 = require("./vendor/vendor-list/vendor-list.component");
var vendor_detail_component_1 = require("./vendor/vendor-detail/vendor-detail.component");
var vendor_add_component_1 = require("./vendor/vendor-add/vendor-add.component");
var vendor_edit_component_1 = require("./vendor/vendor-edit/vendor-edit.component");
var product_service_1 = require("./services/product.service");
var product_list_component_1 = require("./product/product-list/product-list.component");
var product_detail_component_1 = require("./product/product-detail/product-detail.component");
var product_add_component_1 = require("./product/product-add/product-add.component");
var product_edit_component_1 = require("./product/product-edit/product-edit.component");
var system_service_1 = require("./services/system.service");
var purchaserequest_service_1 = require("./services/purchaserequest.service");
var purchaserequest_list_component_1 = require("./purchaserequest/purchaserequest-list/purchaserequest-list.component");
var purchase_detail_component_1 = require("./purchaserequest/purchase-detail/purchase-detail.component");
var purchaserequest_add_component_1 = require("./purchaserequest/purchaserequest-add/purchaserequest-add.component");
var purchaserequest_edit_component_1 = require("./purchaserequest/purchaserequest-edit/purchaserequest-edit.component");
var review_component_1 = require("./review/review/review.component");
var selectreviewitem_component_1 = require("./selectreviewitem/selectreviewitem/selectreviewitem.component");
var purchaserequestlineitem_service_1 = require("./services/purchaserequestlineitem.service");
var purchaserequestlineitem_list_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-list/purchaserequestlineitem-list.component");
var purchaserequestlineitem_add_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-add/purchaserequestlineitem-add.component");
var purchaserequestlineitem_detail_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-detail/purchaserequestlineitem-detail.component");
var purchaserequestlineitem_edit_component_1 = require("./purchaserequestlineitem/purchaserequestlineitem-edit/purchaserequestlineitem-edit.component");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                menu_component_1.MenuComponent,
                heading_component_1.HeadingComponent,
                home_component_1.HomeComponent,
                about_component_1.AboutComponent,
                contact_component_1.ContactComponent,
                help_component_1.HelpComponent,
                login_component_1.LoginComponent,
                user_list_component_1.UserListComponent,
                user_detail_component_1.UserDetailComponent,
                user_edit_component_1.UserEditComponent,
                user_add_component_1.UserAddComponent,
                vendor_list_component_1.VendorListComponent,
                vendor_detail_component_1.VendorDetailComponent,
                vendor_add_component_1.VendorAddComponent,
                vendor_edit_component_1.VendorEditComponent,
                product_list_component_1.ProductListComponent,
                product_detail_component_1.ProductDetailComponent,
                product_add_component_1.ProductAddComponent,
                product_edit_component_1.ProductEditComponent,
                purchaserequest_list_component_1.PurchaserequestListComponent,
                purchase_detail_component_1.PurchaseDetailComponent,
                purchaserequest_add_component_1.PurchaserequestAddComponent,
                purchaserequest_edit_component_1.PurchaserequestEditComponent,
                review_component_1.ReviewComponent,
                selectreviewitem_component_1.SelectreviewitemComponent,
                purchaserequestlineitem_list_component_1.PurchaserequestlineitemListComponent,
                purchaserequestlineitem_add_component_1.PurchaserequestlineitemAddComponent,
                purchaserequestlineitem_detail_component_1.PurchaserequestlineitemDetailComponent,
                purchaserequestlineitem_edit_component_1.PurchaserequestlineitemEditComponent //Your components get added here so the module knows about them.
            ],
            imports: [
                platform_browser_1.BrowserModule,
                forms_1.FormsModule,
                app_routing_module_1.AppRoutingModule,
                http_1.HttpModule
            ],
            providers: [
                user_service_1.UserService,
                vendor_service_1.VendorService,
                product_service_1.ProductService,
                system_service_1.SystemService,
                purchaserequest_service_1.PurchaserequestService,
                purchaserequestlineitem_service_1.PurchaserequestlineitemService
            ],
            bootstrap: [app_component_1.AppComponent] //this is a component that is going to start up automatically when we fire up our application
        })
    ], AppModule);
    return AppModule;
}()); //export just says to Angular that other components outside of this can use this - makes it available throughout your application
exports.AppModule = AppModule;
//when you create a new component - you MUST tell the module about it - or it won't be accessible.  CLI will tell the module 
//about component for you.

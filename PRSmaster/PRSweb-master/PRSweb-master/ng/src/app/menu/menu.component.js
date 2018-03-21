"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var menu_1 = require("./menu");
var MenuComponent = /** @class */ (function () {
    function MenuComponent() {
        this.name = "Menu Component";
        this.menus = [
            new menu_1.Menu("HOME", "/home", "Home menu item"),
            new menu_1.Menu("USERS", "/users", "User list"),
            new menu_1.Menu("LOGIN", "/login", "Login to the app"),
            new menu_1.Menu("ABOUT", "/about", "About menu item"),
            new menu_1.Menu("CONTACT", "/contact", "About me"),
            new menu_1.Menu("HELP", "/help", "When you need help"),
            new menu_1.Menu("VENDORS", "/vendors", "Vendor list"),
            new menu_1.Menu("PRODUCTS", "/products", "Product list"),
            new menu_1.Menu("PURCHASE REQUESTS", "/purchaserequests", "Purchase Request list"),
            new menu_1.Menu("REVIEW", "/review", "Status Review"),
        ];
    } //initializes data in a typescript class
    MenuComponent.prototype.ngOnInit = function () {
    };
    MenuComponent = __decorate([
        core_1.Component({
            selector: 'menu-comp',
            templateUrl: './menu.component.html',
            styleUrls: ['./menu.component.css']
        })
    ], MenuComponent);
    return MenuComponent;
}());
exports.MenuComponent = MenuComponent;

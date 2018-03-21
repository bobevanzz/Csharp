"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Product = /** @class */ (function () {
    function Product(Id, VendorPartNumber, Name, Price, Unit, PhotoPath, VendorId) {
        this.Id = Id;
        this.VendorPartNumber = VendorPartNumber;
        this.Name = Name;
        this.Price = Price;
        this.Unit = Unit;
        this.PhotoPath = PhotoPath;
        this.VendorId = VendorId;
    }
    return Product;
}());
exports.Product = Product;

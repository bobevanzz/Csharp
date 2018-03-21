"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var PurchaseRequestLineItem = /** @class */ (function () {
    function PurchaseRequestLineItem(Id, Quantity, ProductId, PurchaseRequestId) {
        this.Id = Id;
        this.Quantity = Quantity;
        this.ProductId = ProductId;
        this.PurchaseRequestId = PurchaseRequestId;
    }
    return PurchaseRequestLineItem;
}());
exports.PurchaseRequestLineItem = PurchaseRequestLineItem;

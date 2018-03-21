"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Vendor = /** @class */ (function () {
    function Vendor(Id, Code, Name, Address, City, State, Phone, Email, IsPreapproved) {
        this.Id = Id;
        this.Code = Code;
        this.Name = Name;
        this.Address = Address;
        this.City = City;
        this.State = State;
        this.Phone = Phone;
        this.Email = Email;
        this.IsPreapproved = IsPreapproved;
    }
    return Vendor;
}());
exports.Vendor = Vendor;

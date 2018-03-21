"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var User = /** @class */ (function () {
    function User(ID, UserName, Password, FirstName, LastName, Phone, Email, IsReviewer, IsAdmin) {
        this.ID = ID;
        this.UserName = UserName;
        this.Password = Password;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Phone = Phone;
        this.Email = Email;
        this.IsReviewer = IsReviewer;
        this.IsAdmin = IsAdmin;
    }
    return User;
}());
exports.User = User;

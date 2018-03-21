"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Review = /** @class */ (function () {
    function Review(ID, Description, Justification, DateNeeded, DeliveryMode, Status, Total, SubmittedDate, UserId) {
        this.ID = ID;
        this.Description = Description;
        this.Justification = Justification;
        this.DateNeeded = DateNeeded;
        this.DeliveryMode = DeliveryMode;
        this.Status = Status;
        this.Total = Total;
        this.SubmittedDate = SubmittedDate;
        this.UserId = UserId;
    }
    return Review;
}());
exports.Review = Review;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string Description { get; set; }
        public Order() { } //instance of order created here
        public Order(DateTime Date, string Description, decimal Total, int CustomerId)
        {
            this.Id = 0;
            this.Date = Date;
            this.Description = Description;
            this.Total = Total;
            this.CustomerId = CustomerId;
        }
    }
}
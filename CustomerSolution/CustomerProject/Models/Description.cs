using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerProject.Models
{
    public class Description
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public List<Order> Orders { get; set; }
        public Description() { } //instance of order created here
        public Description(int Id)
        {
            this.Id = 0;

        }
    }
}
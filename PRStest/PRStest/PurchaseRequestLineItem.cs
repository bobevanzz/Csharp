using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRStest
{
    public class PurchaseRequestLineItem
    {
        public int Id { get; set; }
        public int PurchaseRequestId { get; set; }
        //public virtual PurchaseRequest PurchaseRequest { get; set; }
        public int ProductId { get; set; }
        //public virtual Product Product { get; set; }
        public int Quantity { get; set; }
       [Required]
        public bool Active { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }

    
}

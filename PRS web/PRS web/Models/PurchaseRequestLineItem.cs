using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class PurchaseRequestLineItem{
        [Required]
        public int Id { get; set; }
        [Required]
        public int PurchaseRequestId { get; set; }
        public virtual PurchaseRequest purchaserequest { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        }
}
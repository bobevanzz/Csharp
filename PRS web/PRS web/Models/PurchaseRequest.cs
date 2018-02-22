using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }
        public virtual User UserId { get; set; }
        public virtual User User { get; set; }
        [StringLength(100)]
        [Required]
        public string Description { get; set; }
        [StringLength(255)]
        [Required]
        public string Justification { get; set; }
        public DateTime DateNeeded { get; set; }
        [StringLength(25)]
        [Required]
        public string DeliveryMode { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public  DateTime SubmittedDate { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        [StringLength(100)]
        public string ReasonForRejection { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
}
}
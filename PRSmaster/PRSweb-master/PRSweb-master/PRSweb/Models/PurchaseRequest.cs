using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRSmaster.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string Description { get; set; }
        [StringLength(50)]
        [Required]
        public string Justification { get; set; }
        [StringLength(50)]
        [Required]
        public string DeliveryMode { get; set; }
        [StringLength(50)]
        [Required]
        public string Status { get; set; }
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public void Clone(PurchaseRequest pr)
        {
            Description = pr.Description;
            Justification = pr.Justification;
            DeliveryMode = pr.DeliveryMode;
            Status = pr.Status;
            Total = pr.Total;
            UserId = pr.UserId;
        }

       
    }
}
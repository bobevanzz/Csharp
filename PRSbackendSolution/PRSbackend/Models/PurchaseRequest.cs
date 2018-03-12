using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRSbackend.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        [Index(IsUnique = true)]
        public string Description { get; set; }
        [StringLength(255)]
        [Required]
        public string Justification { get; set; }
        [StringLength(50)]
        [Required]
        public string DeliveryMode { get; set; }
        [StringLength(50)]
        [Required]
        public string Status { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }
        public string ReasonForRejection { get; set; }
        public DateTime DateCreated { get; set; }
        // [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User user { get; set; }
    }
}
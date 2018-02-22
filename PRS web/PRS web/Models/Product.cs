using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int VendorId { get; set; } 
        public virtual Vendor vendor { get; set; } 
        [StringLength(50)]
        [Required]
        public string PartNumber { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [StringLength(255)]
        [Required]
        public string Unit { get; set; }
        [StringLength(255)]
        public string PhotoPath { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
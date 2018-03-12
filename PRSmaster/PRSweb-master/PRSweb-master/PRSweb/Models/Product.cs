using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRSmaster.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string PartNumber { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [StringLength(255)]
        [Required]
        public string Unit { get; set; }
        [StringLength(255)]
        public string PhotoPath { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
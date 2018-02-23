using System;
using System.ComponentModel.DataAnnotations;

namespace PRStest
{
    public class Product
    {
        public int ID { get; set; }
        public virtual Vendor VendorId { get; set; }
        [StringLength(50)]
        [Required]
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
        [Required]
        public bool Active { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
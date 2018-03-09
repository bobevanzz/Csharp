using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWebApiProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [StringLength(80)]
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public bool Fulfilled { get; set; }

    }
}
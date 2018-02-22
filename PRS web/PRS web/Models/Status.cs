using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class Status
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DateUpdated { get; set; }
    }
}
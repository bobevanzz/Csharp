using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRStest
{
    class Status
    {   [Required]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DateUpdated { get; set; }
        [Required]
        public int UpdatedByUser { get; set; }
    }
}

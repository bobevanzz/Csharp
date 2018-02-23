using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRStest
{
    public class Status
    {   [Required]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? UpdatedByUser { get; set; }
    }
}

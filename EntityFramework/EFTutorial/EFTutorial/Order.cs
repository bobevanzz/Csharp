using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial
{
    public class Order  //create class 
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string Description { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }  
    }
}

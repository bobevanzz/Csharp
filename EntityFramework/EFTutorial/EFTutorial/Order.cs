using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial
{
    public class Order  //create class 
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }  
    }
}

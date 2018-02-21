using System;
using System.Collections.Generic;
using System.Data.Entity; //added to inherit DbContext always do this
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial
{
    public class IntroDbContext: DbContext
    {
        public IntroDbContext() : base()
        {

        }
        public virtual DbSet<Customer>Customers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRStest
{
    class IntroDbContext : DbContext
    {
        public IntroDbContext() : base(/*"name=ConnectionStringName"*/)//.config ConnectionStrings edit here
        {

        }
        public virtual DbSet<User> Users { get; set; }

    }
}

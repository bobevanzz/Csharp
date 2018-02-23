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
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public virtual DbSet<PurchaseRequestLineItem> PurchaseRequestLineItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}

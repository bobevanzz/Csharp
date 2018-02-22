using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class 
    {
        public PRS_dbContext() : base("name=PRS_dbContext")
        {
        }

        public System.Data.Entity.DbSet<PRS_web.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<PRS_web.Models.Vendor> Vendors { get; set; }
        public System.Data.Entity.DbSet<PRS_web.Models.Status> Statuses { get; set; }
        public System.Data.Entity.DbSet<PRS_web.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<PRS_web.Models.PurchaseRequest> PurchaseRequests { get; set; }

        public System.Data.Entity.DbSet<PRS_web.Models.PurchaseRequestLineItem> PurchaseRequestLineItems { get; set; }
    }
}
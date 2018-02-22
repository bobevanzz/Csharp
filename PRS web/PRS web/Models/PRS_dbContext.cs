﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRS_web.Models
{
    public class PRS_dbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
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

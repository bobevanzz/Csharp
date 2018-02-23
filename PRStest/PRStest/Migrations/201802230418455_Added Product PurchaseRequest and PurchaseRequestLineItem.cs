namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductPurchaseRequestandPurchaseRequestLineItem : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Vendors", new[] { "Code" });
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PartNumber = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 150),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(nullable: false, maxLength: 255),
                        PhotoPath = c.String(maxLength: 255),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        vendor_Id = c.Int(),
                        VendorId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vendors", t => t.vendor_Id)
                .ForeignKey("dbo.Vendors", t => t.VendorId_Id)
                .Index(t => t.vendor_Id)
                .Index(t => t.VendorId_Id);
            
            CreateTable(
                "dbo.PurchaseRequestLineItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseRequestId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseRequests", t => t.PurchaseRequestId, cascadeDelete: true)
                .Index(t => t.PurchaseRequestId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.PurchaseRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        Justification = c.String(nullable: false, maxLength: 255),
                        DateNeeded = c.DateTime(nullable: false),
                        DeliveryMode = c.String(nullable: false, maxLength: 25),
                        StatusId = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        SubmittedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        ReasonForRejection = c.String(nullable: false, maxLength: 100),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        User_id = c.Int(),
                        UserId_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .ForeignKey("dbo.Users", t => t.UserId_id)
                .Index(t => t.User_id)
                .Index(t => t.UserId_id);
            
            AddColumn("dbo.Vendors", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Vendors", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vendors", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vendors", "Code", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Vendors", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vendors", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vendors", "City", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vendors", "Email", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Vendors", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseRequestLineItems", "PurchaseRequestId", "dbo.PurchaseRequests");
            DropForeignKey("dbo.PurchaseRequests", "UserId_id", "dbo.Users");
            DropForeignKey("dbo.PurchaseRequests", "User_id", "dbo.Users");
            DropForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "VendorId_Id", "dbo.Vendors");
            DropForeignKey("dbo.Products", "vendor_Id", "dbo.Vendors");
            DropIndex("dbo.PurchaseRequests", new[] { "UserId_id" });
            DropIndex("dbo.PurchaseRequests", new[] { "User_id" });
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "ProductId" });
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "PurchaseRequestId" });
            DropIndex("dbo.Vendors", new[] { "Code" });
            DropIndex("dbo.Products", new[] { "VendorId_Id" });
            DropIndex("dbo.Products", new[] { "vendor_Id" });
            AlterColumn("dbo.Vendors", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vendors", "City", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vendors", "Address", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vendors", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vendors", "Code", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Vendors", "DateUpdated");
            DropColumn("dbo.Vendors", "DateCreated");
            DropColumn("dbo.Vendors", "Active");
            DropTable("dbo.PurchaseRequests");
            DropTable("dbo.PurchaseRequestLineItems");
            DropTable("dbo.Products");
            CreateIndex("dbo.Vendors", "Code", unique: true);
        }
    }
}

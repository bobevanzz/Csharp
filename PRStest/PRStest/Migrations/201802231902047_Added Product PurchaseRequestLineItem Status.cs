namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductPurchaseRequestLineItemStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Products", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Vendors", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Vendors", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequestLineItems", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequestLineItems", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Status", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Status", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Status", "UpdatedByUser", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Status", "UpdatedByUser", c => c.Int(nullable: false));
            AlterColumn("dbo.Status", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Status", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequestLineItems", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequestLineItems", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vendors", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vendors", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateCreated", c => c.DateTime(nullable: false));
        }
    }
}

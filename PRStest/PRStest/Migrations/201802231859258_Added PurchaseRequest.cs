namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPurchaseRequest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PurchaseRequests", "DateNeeded", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequests", "StatusId", c => c.Int());
            AlterColumn("dbo.PurchaseRequests", "SubmittedDate", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequests", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequests", "DateUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PurchaseRequests", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequests", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequests", "SubmittedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequests", "StatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseRequests", "DateNeeded", c => c.DateTime(nullable: false));
        }
    }
}

namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PurchaseRequestLineItems", "PurchaseRequestId", "dbo.PurchaseRequests");
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "PurchaseRequestId" });
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "ProductId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.PurchaseRequestLineItems", "ProductId");
            CreateIndex("dbo.PurchaseRequestLineItems", "PurchaseRequestId");
            AddForeignKey("dbo.PurchaseRequestLineItems", "PurchaseRequestId", "dbo.PurchaseRequests", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products", "ID", cascadeDelete: true);
        }
    }
}

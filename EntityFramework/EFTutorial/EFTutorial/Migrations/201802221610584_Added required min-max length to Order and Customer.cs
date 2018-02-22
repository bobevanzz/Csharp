namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedrequiredminmaxlengthtoOrderandCustomer : DbMigration
    {  
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String( maxLength: 50));
            AlterColumn("dbo.Customers", "City", c => c.String( maxLength: 30));
            AlterColumn("dbo.Customers", "State", c => c.String( maxLength: 2));
            AlterColumn("dbo.Orders", "Description", c => c.String( maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Description", c => c.String());
            AlterColumn("dbo.Customers", "State", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}

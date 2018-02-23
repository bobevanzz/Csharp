namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
        }
    }
}

namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 75));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
    }
}

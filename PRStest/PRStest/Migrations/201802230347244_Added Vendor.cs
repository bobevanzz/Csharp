namespace PRStest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVendor : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 30),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 30),
                        State = c.String(nullable: false, maxLength: 2),
                        Zip = c.String(nullable: false, maxLength: 5),
                        Phone = c.String(nullable: false, maxLength: 12),
                        Email = c.String(nullable: false, maxLength: 30),
                        IsPreApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Code, unique: true);
            
            AddColumn("dbo.Users", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 75));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vendors", new[] { "Code" });
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Users", "DateUpdated");
            DropColumn("dbo.Users", "DateCreated");
            DropColumn("dbo.Users", "Active");
            DropTable("dbo.Vendors");
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
    }
}

namespace StudentTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Major = c.String(nullable: false, maxLength: 30),
                        College = c.String(nullable: false, maxLength: 30),
                        GradYear = c.Int(nullable: false),
                        GradWithHonors = c.Boolean(nullable: false),
                        AlumniDonor = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}

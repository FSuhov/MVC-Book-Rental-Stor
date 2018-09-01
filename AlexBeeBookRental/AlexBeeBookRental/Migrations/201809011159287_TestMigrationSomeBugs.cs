namespace AlexBeeBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigrationSomeBugs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            DropColumn("dbo.AspNetUsers", "LasttName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LasttName", c => c.String());
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}

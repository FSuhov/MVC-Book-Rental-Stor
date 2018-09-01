namespace AlexBeeBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraFieldsToUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LasttName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Disabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MembershipTypeId");
            DropColumn("dbo.AspNetUsers", "Disabled");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "LasttName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}

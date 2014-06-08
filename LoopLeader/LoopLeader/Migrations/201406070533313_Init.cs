namespace LoopLeader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "EmailAddress", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "StreetAddress", c => c.String(maxLength: 100));
            AddColumn("dbo.AspNetUsers", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "State", c => c.String(maxLength: 20));
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "Country", c => c.String(maxLength: 65));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "StreetAddress");
            DropColumn("dbo.AspNetUsers", "EmailAddress");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}

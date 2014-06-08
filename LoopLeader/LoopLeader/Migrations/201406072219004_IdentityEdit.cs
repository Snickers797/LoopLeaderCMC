namespace LoopLeader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "EmailAddress", c => c.String());
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.String());
            AlterColumn("dbo.AspNetUsers", "City", c => c.String());
            AlterColumn("dbo.AspNetUsers", "State", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Country", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Country", c => c.String(maxLength: 65));
            AlterColumn("dbo.AspNetUsers", "State", c => c.String(maxLength: 20));
            AlterColumn("dbo.AspNetUsers", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.AspNetUsers", "EmailAddress", c => c.String(maxLength: 50));
        }
    }
}

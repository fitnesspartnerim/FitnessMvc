namespace FitnessMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameAndSurnameToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}

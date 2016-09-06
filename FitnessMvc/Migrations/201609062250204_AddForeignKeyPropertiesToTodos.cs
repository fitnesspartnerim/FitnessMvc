namespace FitnessMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToTodos : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Todos", name: "User_Id", newName: "UserId");
            RenameIndex(table: "dbo.Todos", name: "IX_User_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Todos", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Todos", name: "UserId", newName: "User_Id");
        }
    }
}

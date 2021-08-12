namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCategoryToPassword : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Passwords", name: "Category_Id", newName: "CategoryId_Id");
            RenameIndex(table: "dbo.Passwords", name: "IX_Category_Id", newName: "IX_CategoryId_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Passwords", name: "IX_CategoryId_Id", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Passwords", name: "CategoryId_Id", newName: "Category_Id");
        }
    }
}

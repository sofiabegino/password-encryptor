namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCategoryToCreditCard : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CreditCards", name: "Category_Id", newName: "CategoryId_Id");
            RenameIndex(table: "dbo.CreditCards", name: "IX_Category_Id", newName: "IX_CategoryId_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CreditCards", name: "IX_CategoryId_Id", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.CreditCards", name: "CategoryId_Id", newName: "Category_Id");
        }
    }
}

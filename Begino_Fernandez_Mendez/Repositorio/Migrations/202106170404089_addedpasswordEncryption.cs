namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpasswordEncryption : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Password_Id", "dbo.Passwords");
            DropIndex("dbo.Users", new[] { "Password_Id" });
            RenameColumn(table: "dbo.CreditCards", name: "Category_Id", newName: "CategoryId_Id");
            RenameIndex(table: "dbo.CreditCards", name: "IX_Category_Id", newName: "IX_CategoryId_Id");
            CreateTable(
                "dbo.DataBreachesResultCreditCards",
                c => new
                    {
                        DataBreachesResult_Id = c.Int(nullable: false),
                        CreditCard_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DataBreachesResult_Id, t.CreditCard_Id })
                .ForeignKey("dbo.DataBreachesResults", t => t.DataBreachesResult_Id, cascadeDelete: true)
                .ForeignKey("dbo.CreditCards", t => t.CreditCard_Id, cascadeDelete: true)
                .Index(t => t.DataBreachesResult_Id)
                .Index(t => t.CreditCard_Id);
            
            CreateTable(
                "dbo.PasswordDataBreachesResults",
                c => new
                    {
                        Password_Id = c.Int(nullable: false),
                        DataBreachesResult_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Password_Id, t.DataBreachesResult_Id })
                .ForeignKey("dbo.Passwords", t => t.Password_Id, cascadeDelete: true)
                .ForeignKey("dbo.DataBreachesResults", t => t.DataBreachesResult_Id, cascadeDelete: true)
                .Index(t => t.Password_Id)
                .Index(t => t.DataBreachesResult_Id);
            
            CreateTable(
                "dbo.PasswordUsers",
                c => new
                    {
                        Password_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Password_Id, t.User_Id })
                .ForeignKey("dbo.Passwords", t => t.Password_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Password_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.DataBreachesResults", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.DataBreachesResults", "Time", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Users", "Password_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password_Id", c => c.Int());
            DropForeignKey("dbo.PasswordUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PasswordUsers", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.PasswordDataBreachesResults", "DataBreachesResult_Id", "dbo.DataBreachesResults");
            DropForeignKey("dbo.PasswordDataBreachesResults", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.DataBreachesResultCreditCards", "CreditCard_Id", "dbo.CreditCards");
            DropForeignKey("dbo.DataBreachesResultCreditCards", "DataBreachesResult_Id", "dbo.DataBreachesResults");
            DropIndex("dbo.PasswordUsers", new[] { "User_Id" });
            DropIndex("dbo.PasswordUsers", new[] { "Password_Id" });
            DropIndex("dbo.PasswordDataBreachesResults", new[] { "DataBreachesResult_Id" });
            DropIndex("dbo.PasswordDataBreachesResults", new[] { "Password_Id" });
            DropIndex("dbo.DataBreachesResultCreditCards", new[] { "CreditCard_Id" });
            DropIndex("dbo.DataBreachesResultCreditCards", new[] { "DataBreachesResult_Id" });
            DropColumn("dbo.DataBreachesResults", "Time");
            DropColumn("dbo.DataBreachesResults", "Date");
            DropTable("dbo.PasswordUsers");
            DropTable("dbo.PasswordDataBreachesResults");
            DropTable("dbo.DataBreachesResultCreditCards");
            RenameIndex(table: "dbo.CreditCards", name: "IX_CategoryId_Id", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.CreditCards", name: "CategoryId_Id", newName: "Category_Id");
            CreateIndex("dbo.Users", "Password_Id");
            AddForeignKey("dbo.Users", "Password_Id", "dbo.Passwords", "Id");
        }
    }
}

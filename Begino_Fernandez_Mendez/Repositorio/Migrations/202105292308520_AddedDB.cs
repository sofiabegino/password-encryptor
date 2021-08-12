namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Number = c.String(nullable: false, maxLength: 128),
                        Category = c.String(),
                        Name = c.String(maxLength: 128),
                        Type = c.String(),
                        Code = c.String(),
                        ExpirationDate = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.Categories", t => t.Name)
                .Index(t => t.Name);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        User_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Users", t => t.User_Name)
                .Index(t => t.User_Name);
            
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Site = c.String(nullable: false, maxLength: 128),
                        Category = c.String(),
                        Pass = c.String(),
                        PasswordLength = c.Int(nullable: false),
                        UpperCase = c.Boolean(nullable: false),
                        LowerCase = c.Boolean(nullable: false),
                        Digits = c.Boolean(nullable: false),
                        Special = c.Boolean(nullable: false),
                        Notes = c.String(),
                        Strength = c.Int(nullable: false),
                        Shared = c.Boolean(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Category_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Username, t.Site })
                .ForeignKey("dbo.Categories", t => t.Category_Name)
                .Index(t => t.Category_Name);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Password_Username = c.String(maxLength: 128),
                        Password_Site = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Passwords", t => new { t.Password_Username, t.Password_Site })
                .Index(t => new { t.Password_Username, t.Password_Site });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "Category_Name", "dbo.Categories");
            DropForeignKey("dbo.Users", new[] { "Password_Username", "Password_Site" }, "dbo.Passwords");
            DropForeignKey("dbo.Categories", "User_Name", "dbo.Users");
            DropForeignKey("dbo.CreditCards", "Name", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "Password_Username", "Password_Site" });
            DropIndex("dbo.Passwords", new[] { "Category_Name" });
            DropIndex("dbo.Categories", new[] { "User_Name" });
            DropIndex("dbo.CreditCards", new[] { "Name" });
            DropTable("dbo.Users");
            DropTable("dbo.Passwords");
            DropTable("dbo.Categories");
            DropTable("dbo.CreditCards");
        }
    }
}

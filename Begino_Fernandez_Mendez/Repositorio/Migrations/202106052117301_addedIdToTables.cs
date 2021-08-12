namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIdToTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CreditCards", "Name", "dbo.Categories");
            DropForeignKey("dbo.Users", new[] { "Password_Username", "Password_Site" }, "dbo.Passwords");
            DropForeignKey("dbo.Passwords", "Category_Name", "dbo.Categories");
            DropForeignKey("dbo.Categories", "User_Name", "dbo.Users");
            DropIndex("dbo.CreditCards", new[] { "Name" });
            DropIndex("dbo.Categories", new[] { "User_Name" });
            DropIndex("dbo.Passwords", new[] { "Category_Name" });
            DropIndex("dbo.Users", new[] { "Password_Username", "Password_Site" });
            RenameColumn(table: "dbo.Passwords", name: "Category_Name", newName: "Category_Id");
            RenameColumn(table: "dbo.Users", name: "Password_Username", newName: "Password_Id");
            RenameColumn(table: "dbo.Categories", name: "User_Name", newName: "User_Id");
            DropPrimaryKey("dbo.CreditCards");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Passwords");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.CreditCards", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CreditCards", "Category_Id", c => c.Int());
            AddColumn("dbo.Categories", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Passwords", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CreditCards", "Number", c => c.String());
            AlterColumn("dbo.CreditCards", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Categories", "User_Id", c => c.Int());
            AlterColumn("dbo.Passwords", "Username", c => c.String());
            AlterColumn("dbo.Passwords", "Site", c => c.String());
            AlterColumn("dbo.Passwords", "Category_Id", c => c.Int());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "Password_Id", c => c.Int());
            AddPrimaryKey("dbo.CreditCards", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Passwords", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.CreditCards", "Category_Id");
            CreateIndex("dbo.Categories", "User_Id");
            CreateIndex("dbo.Passwords", "Category_Id");
            CreateIndex("dbo.Users", "Password_Id");
            AddForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Users", "Password_Id", "dbo.Passwords", "Id");
            AddForeignKey("dbo.Passwords", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Categories", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Users", "Password_Site");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password_Site", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Categories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Passwords", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Users", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "Password_Id" });
            DropIndex("dbo.Passwords", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "User_Id" });
            DropIndex("dbo.CreditCards", new[] { "Category_Id" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Passwords");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.CreditCards");
            AlterColumn("dbo.Users", "Password_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Passwords", "Category_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Passwords", "Site", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Passwords", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Categories", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CreditCards", "Name", c => c.String(maxLength: 128));
            AlterColumn("dbo.CreditCards", "Number", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Passwords", "Id");
            DropColumn("dbo.Categories", "Id");
            DropColumn("dbo.CreditCards", "Category_Id");
            DropColumn("dbo.CreditCards", "Id");
            AddPrimaryKey("dbo.Users", "Name");
            AddPrimaryKey("dbo.Passwords", new[] { "Username", "Site" });
            AddPrimaryKey("dbo.Categories", "Name");
            AddPrimaryKey("dbo.CreditCards", "Number");
            RenameColumn(table: "dbo.Categories", name: "User_Id", newName: "User_Name");
            RenameColumn(table: "dbo.Users", name: "Password_Id", newName: "Password_Username");
            RenameColumn(table: "dbo.Passwords", name: "Category_Id", newName: "Category_Name");
            CreateIndex("dbo.Users", new[] { "Password_Username", "Password_Site" });
            CreateIndex("dbo.Passwords", "Category_Name");
            CreateIndex("dbo.Categories", "User_Name");
            CreateIndex("dbo.CreditCards", "Name");
            AddForeignKey("dbo.Categories", "User_Name", "dbo.Users", "Name");
            AddForeignKey("dbo.Passwords", "Category_Name", "dbo.Categories", "Name");
            AddForeignKey("dbo.Users", new[] { "Password_Username", "Password_Site" }, "dbo.Passwords", new[] { "Username", "Site" });
            AddForeignKey("dbo.CreditCards", "Name", "dbo.Categories", "Name");
        }
    }
}

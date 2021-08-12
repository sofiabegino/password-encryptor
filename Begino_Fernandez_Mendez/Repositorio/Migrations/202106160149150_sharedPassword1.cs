namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sharedPassword1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.Users", "Password_Id1", "dbo.Passwords");
            DropForeignKey("dbo.Passwords", "User_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Password_Id" });
            DropIndex("dbo.Users", new[] { "Password_Id1" });
            DropIndex("dbo.Passwords", new[] { "User_Id" });
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
            
            DropColumn("dbo.Users", "Password_Id");
            DropColumn("dbo.Users", "Password_Id1");
            DropColumn("dbo.Passwords", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passwords", "User_Id", c => c.Int());
            AddColumn("dbo.Users", "Password_Id1", c => c.Int());
            AddColumn("dbo.Users", "Password_Id", c => c.Int());
            DropForeignKey("dbo.PasswordUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PasswordUsers", "Password_Id", "dbo.Passwords");
            DropIndex("dbo.PasswordUsers", new[] { "User_Id" });
            DropIndex("dbo.PasswordUsers", new[] { "Password_Id" });
            DropTable("dbo.PasswordUsers");
            CreateIndex("dbo.Passwords", "User_Id");
            CreateIndex("dbo.Users", "Password_Id1");
            CreateIndex("dbo.Users", "Password_Id");
            AddForeignKey("dbo.Passwords", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Password_Id1", "dbo.Passwords", "Id");
            AddForeignKey("dbo.Users", "Password_Id", "dbo.Passwords", "Id");
        }
    }
}

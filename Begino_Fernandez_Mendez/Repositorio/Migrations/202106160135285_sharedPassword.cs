namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sharedPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password_Id1", c => c.Int());
            AddColumn("dbo.Passwords", "User_Id", c => c.Int());
            CreateIndex("dbo.Users", "Password_Id1");
            CreateIndex("dbo.Passwords", "User_Id");
            AddForeignKey("dbo.Users", "Password_Id1", "dbo.Passwords", "Id");
            AddForeignKey("dbo.Passwords", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Password_Id1", "dbo.Passwords");
            DropIndex("dbo.Passwords", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Password_Id1" });
            DropColumn("dbo.Passwords", "User_Id");
            DropColumn("dbo.Users", "Password_Id1");
        }
    }
}

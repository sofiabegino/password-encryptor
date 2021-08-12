namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDataBreachesClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataBreachesResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Passwords", "ChangedInDataBreches", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DataBreachesResults", "User_Id", "dbo.Users");
            DropIndex("dbo.DataBreachesResults", new[] { "User_Id" });
            DropColumn("dbo.Passwords", "ChangedInDataBreches");
            DropTable("dbo.DataBreachesResults");
        }
    }
}

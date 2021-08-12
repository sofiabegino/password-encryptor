namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedPasswordAtribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passwords", "isUpdated", c => c.Boolean(nullable: false));
            DropColumn("dbo.Passwords", "ChangedInDataBreches");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passwords", "ChangedInDataBreches", c => c.Boolean(nullable: false));
            DropColumn("dbo.Passwords", "isUpdated");
        }
    }
}

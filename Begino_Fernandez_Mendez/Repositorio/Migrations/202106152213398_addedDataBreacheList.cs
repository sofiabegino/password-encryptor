namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDataBreacheList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataBreachesResults", "CreditCard_Id", c => c.Int());
            AddColumn("dbo.DataBreachesResults", "Password_Id", c => c.Int());

            DropForeignKey("dbo.DataBreachesResults", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.DataBreachesResults", "CreditCard_Id", "dbo.CreditCards");
            DropIndex("dbo.DataBreachesResults", new[] { "Password_Id" });
            DropIndex("dbo.DataBreachesResults", new[] { "CreditCard_Id" });
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
            
            AddColumn("dbo.DataBreachesResults", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.DataBreachesResults", "Time", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.DataBreachesResults", "Password_Id");
            DropColumn("dbo.DataBreachesResults", "CreditCard_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DataBreachesResults", "CreditCard_Id", c => c.Int());
            AddColumn("dbo.DataBreachesResults", "Password_Id", c => c.Int());
            DropForeignKey("dbo.PasswordDataBreachesResults", "DataBreachesResult_Id", "dbo.DataBreachesResults");
            DropForeignKey("dbo.PasswordDataBreachesResults", "Password_Id", "dbo.Passwords");
            DropForeignKey("dbo.DataBreachesResultCreditCards", "CreditCard_Id", "dbo.CreditCards");
            DropForeignKey("dbo.DataBreachesResultCreditCards", "DataBreachesResult_Id", "dbo.DataBreachesResults");
            DropIndex("dbo.PasswordDataBreachesResults", new[] { "DataBreachesResult_Id" });
            DropIndex("dbo.PasswordDataBreachesResults", new[] { "Password_Id" });
            DropIndex("dbo.DataBreachesResultCreditCards", new[] { "CreditCard_Id" });
            DropIndex("dbo.DataBreachesResultCreditCards", new[] { "DataBreachesResult_Id" });
            DropColumn("dbo.DataBreachesResults", "Time");
            DropColumn("dbo.DataBreachesResults", "Date");
            DropTable("dbo.PasswordDataBreachesResults");
            DropTable("dbo.DataBreachesResultCreditCards");
            CreateIndex("dbo.DataBreachesResults", "CreditCard_Id");
            CreateIndex("dbo.DataBreachesResults", "Password_Id");
            AddForeignKey("dbo.DataBreachesResults", "CreditCard_Id", "dbo.CreditCards", "Id");
            AddForeignKey("dbo.DataBreachesResults", "Password_Id", "dbo.Passwords", "Id");
        }
    }
}

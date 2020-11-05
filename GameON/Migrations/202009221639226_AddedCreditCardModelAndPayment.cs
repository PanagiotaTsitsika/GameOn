namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCreditCardModelAndPayment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CreditCardUserId = c.String(nullable: false, maxLength: 128),
                        ExpireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CreditCardUserId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreditCardUserId)
                .Index(t => t.CreditCardUserId);
            
            AddColumn("dbo.AspNetUsers", "IsSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "CreditCardUserId", "dbo.AspNetUsers");
            DropIndex("dbo.CreditCards", new[] { "CreditCardUserId" });
            DropColumn("dbo.AspNetUsers", "IsSubscribed");
            DropTable("dbo.CreditCards");
        }
    }
}

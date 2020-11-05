namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCreditCardProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CreditCards", "CardNumber", c => c.String());
            AddColumn("dbo.CreditCards", "CCV", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CreditCards", "CCV");
            DropColumn("dbo.CreditCards", "CardNumber");
        }
    }
}

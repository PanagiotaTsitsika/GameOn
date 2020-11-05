namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCancelled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "IsCancelled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tournaments", "IsCancelled");
        }
    }
}

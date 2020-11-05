namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTournametVenue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "Venue", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tournaments", "Venue");
        }
    }
}

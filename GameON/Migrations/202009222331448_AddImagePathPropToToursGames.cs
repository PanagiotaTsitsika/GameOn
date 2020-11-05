namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathPropToToursGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "ImagePath", c => c.String());
            AddColumn("dbo.Games", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "ImagePath");
            DropColumn("dbo.Tournaments", "ImagePath");
        }
    }
}

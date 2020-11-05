namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveOriginalTitleFromNotification : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Notifications", "OriginalTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "OriginalTitle", c => c.String());
        }
    }
}

namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApiNotificationsController : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "OriginalTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "OriginalTitle");
        }
    }
}

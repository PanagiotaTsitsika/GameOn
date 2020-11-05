namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tournaments", name: "Host_Id", newName: "HostId");
            RenameIndex(table: "dbo.Tournaments", name: "IX_Host_Id", newName: "IX_HostId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tournaments", name: "IX_HostId", newName: "IX_Host_Id");
            RenameColumn(table: "dbo.Tournaments", name: "HostId", newName: "Host_Id");
        }
    }
}

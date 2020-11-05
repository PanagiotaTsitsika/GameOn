namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParticipationAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participations",
                c => new
                    {
                        GamerId = c.String(nullable: false, maxLength: 128),
                        TournamentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GamerId, t.TournamentId })
                .ForeignKey("dbo.AspNetUsers", t => t.GamerId, cascadeDelete: true)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId)
                .Index(t => t.GamerId)
                .Index(t => t.TournamentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participations", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.Participations", "GamerId", "dbo.AspNetUsers");
            DropIndex("dbo.Participations", new[] { "TournamentId" });
            DropIndex("dbo.Participations", new[] { "GamerId" });
            DropTable("dbo.Participations");
        }
    }
}

namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exxxodia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Genre_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Game_Id = c.Int(nullable: false),
                        Host_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Host_Id, cascadeDelete: true)
                .Index(t => t.Game_Id)
                .Index(t => t.Host_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tournaments", "Host_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tournaments", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Tournaments", new[] { "Host_Id" });
            DropIndex("dbo.Tournaments", new[] { "Game_Id" });
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropTable("dbo.Tournaments");
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
        }
    }
}

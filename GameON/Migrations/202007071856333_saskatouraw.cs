namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saskatouraw : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Games", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.Tournaments", name: "Game_Id", newName: "GameId");
            RenameIndex(table: "dbo.Games", name: "IX_Genre_Id", newName: "IX_GenreId");
            RenameIndex(table: "dbo.Tournaments", name: "IX_Game_Id", newName: "IX_GameId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tournaments", name: "IX_GameId", newName: "IX_Game_Id");
            RenameIndex(table: "dbo.Games", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Tournaments", name: "GameId", newName: "Game_Id");
            RenameColumn(table: "dbo.Games", name: "GenreId", newName: "Genre_Id");
        }
    }
}

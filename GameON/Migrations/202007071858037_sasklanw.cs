namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sasklanw : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) VALUES(1,'RPG')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(2,'FPS')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(3,'MMO')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(4,'MPF')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(5,'Strategy')");
            Sql("INSERT INTO Games (Title,Description,GenreId) VALUES ('mana PF ', 'xonomaste sti milfara',1)");
            Sql("INSERT INTO Games (Title,Description,GenreId) VALUES ('mana DB ', 'xonomaste sti milfara',3)");
            Sql("INSERT INTO Games (Title,Description,GenreId) VALUES ('mana GC ', 'xonomaste sti milfara',2)");
            Sql("INSERT INTO Games (Title,Description,GenreId) VALUES ('mana GT ', 'xonomaste sti milfara',4)");
            Sql("INSERT INTO Games (Title,Description,GenreId) VALUES ('mana PT ', 'xonomaste sti milfara',5)");
        }

        public override void Down()
        {
        }
    }
}

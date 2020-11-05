namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Games SET Title= 'Call of Duty', GenreId=1 WHERE Id=1");
            Sql("UPDATE Games SET Title= 'Halo', GenreId=1 WHERE Id=2");
            Sql("UPDATE Games SET Title= 'Mortal Kombat', GenreId=1 WHERE Id=3");
            Sql("UPDATE Games SET Title= 'Street Fighter', GenreId=1 WHERE Id=4");
            Sql("UPDATE Games SET Title= 'Fortnite', GenreId=1 WHERE Id=5");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('The Legend of Zelda',3)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Resident Evil',3)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Metroid',3)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Final Fantasy',4)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Pokémon',4)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('World of Warcraft',4)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Civilization',5)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Age of Empires',5)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('League of Legends',5)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('The Sims',6)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('RollerCoaster Tycoon',6)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('FIFA International Soccer',7)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('NBA 2K',7)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('ProEvolution Soccer',7)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Super Mario Kart',8)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Midnight Club: Street Racing',8)");
            Sql("INSERT INTO Games (Title,GenreId) VALUES ('Football Manager',7)");

        }

        public override void Down()
        {
        }
    }
}

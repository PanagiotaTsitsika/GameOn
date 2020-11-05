namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenres : DbMigration
    {
       public override void Up()
        {
            Sql("UPDATE GENRES SET Name='Action' WHERE Id=1");
            Sql("UPDATE GENRES SET Name='Adventure' WHERE Id=2");
            Sql("UPDATE GENRES SET Name='Action-adventure' WHERE Id=3");
            Sql("UPDATE GENRES SET Name='Role-playing' WHERE Id=4");
            Sql("UPDATE GENRES SET Name='Strategy' WHERE Id=5");
            Sql("INSERT INTO GENRES(Id,Name) VALUES (6, 'Simulation')");
            Sql("INSERT INTO GENRES(Id,Name) VALUES (7, 'Sports')");
            Sql("INSERT INTO GENRES(Id,Name) VALUES (8, 'Racing')");

        }

        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE Id IN (1,2,3,4,5,6,7,8)");
        }
    }
}

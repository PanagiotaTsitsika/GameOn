namespace GameON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameUrl : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE GAMES SET DESCRIPTION=' ', IMAGEPATH ='images/codwarzone.png' WHERE ID = 1");
            Sql("UPDATE GAMES SET DESCRIPTION=' ', IMAGEPATH ='images/haloinf.png' WHERE ID = 2");
            Sql("UPDATE GAMES SET DESCRIPTION=' ', IMAGEPATH ='images/mk11.jpg' WHERE ID = 3");
            Sql("UPDATE GAMES SET DESCRIPTION=' ', IMAGEPATH ='images/sf5.jpg' WHERE ID = 4");
            Sql("UPDATE GAMES SET DESCRIPTION=' ', IMAGEPATH ='images/fortnite.jpg' WHERE ID = 5");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/tloz.jpg' WHERE ID = 6");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/re3.png' WHERE ID = 7");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/metp3.jpg' WHERE ID = 8");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/ffvii.jpg' WHERE ID = 9");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/pokemonS2.jpg' WHERE ID = 10");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/bestgamewow.jpg' WHERE ID = 11");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/civ5.jpg' WHERE ID = 12");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/AoE3.jpg' WHERE ID = 13");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/lol.jpg' WHERE ID = 14");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/ts4.jpg' WHERE ID = 15");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/rct.jpg' WHERE ID = 16");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/fifa19.jpg' WHERE ID = 17");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/NBA2K20.jpg' WHERE ID = 18");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/pes2019.jpg' WHERE ID = 19");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/mc8.jpg' WHERE ID = 20");
            Sql("UPDATE GAMES SET IMAGEPATH ='images/mk11.jpg' WHERE ID = 21");


        }

        public override void Down()
        {
        }
    }
}

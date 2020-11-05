namespace GameON.Core.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public GenreDto Genre { get; set; }
        public string Description { get; set; }

    }
}
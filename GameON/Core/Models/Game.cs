using System.ComponentModel.DataAnnotations;

namespace GameON.Core.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 3, ErrorMessage = "vale ena sosto megethos GTPS")]
        public string Title { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }

        [Display(Name = "Photo")]
        public string ImagePath { get; set; }
    }
}
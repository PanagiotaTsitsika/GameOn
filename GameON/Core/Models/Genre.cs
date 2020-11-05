using System.ComponentModel.DataAnnotations;

namespace GameON.Core.Models
{
    public class Genre
    {

        public byte Id { get; set; }
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 3, ErrorMessage = "vale ena sosto megethos GTPS")]
        public string Name { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameON.Core.Models
{
    public class Participation
    {
        public ApplicationUser Gamer { get; set; }
        public Tournament Tournament { get; set; }
        [Key]
        [Column(Order = 1)]
        public string GamerId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TournamentId { get; set; }
    }
}
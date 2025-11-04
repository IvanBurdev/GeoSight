using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class GameRound
    {
        [Key]
        public int RoundID { get; set; }

        [ForeignKey("Game")]
        public int GameID { get; set; }

        [ForeignKey("Sight")]
        public int SightID { get; set; }

        public bool IsSightCorrect { get; set; } = false;
        public bool IsFlagCorrect { get; set; } = false;
        public bool IsCapitalCorrect { get; set; } = false;

        // Navigation
        public virtual Game Game { get; set; }
        public virtual Sight Sight { get; set; }
    }
}

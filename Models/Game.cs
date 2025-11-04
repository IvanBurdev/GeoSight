using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public DateTime StartTime { get; set; } = DateTime.Now;

        public DateTime? EndTime { get; set; }

        public int LivesRemaining { get; set; } = 3;

        public int Score { get; set; } = 0;

        // Navigation
        public virtual User User { get; set; }
        public virtual ICollection<GameRound> GameRounds { get; set; }
    }
}

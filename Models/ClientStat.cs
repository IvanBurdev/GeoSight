using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class ClientStat
    {
        [Key]
        public int StatID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public int GuessStreak { get; set; } = 0;

        public int GamesPlayed { get; set; } = 0;

        [NotMapped]
        public int DaysOnPlatform => (int)(System.DateTime.Now - User.DateJoined).TotalDays;

        // Navigation property
        public virtual User User { get; set; }
    }
}

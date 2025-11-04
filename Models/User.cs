using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; } // "Client" or "Admin"

        public DateTime DateJoined { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual ClientStat ClientStat { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<AdminAction> AdminActions { get; set; }
    }
}

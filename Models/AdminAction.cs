using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class AdminAction
    {
        [Key]
        public int ActionID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }

        [StringLength(100)]
        public string ActionType { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime ActionDate { get; set; } = DateTime.Now;

        // Navigation
        public virtual User Admin { get; set; }
    }
}

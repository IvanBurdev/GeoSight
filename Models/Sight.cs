using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class Sight
    {
        [Key]
        public int SightID { get; set; }

        [Required, StringLength(150)]
        public string SightName { get; set; }

        [Required, StringLength(255)]
        public string ImageURL { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }

        // Navigation
        public virtual Country Country { get; set; }
    }
}

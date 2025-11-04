using System.ComponentModel.DataAnnotations;

namespace GeoSight.Models
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [Required, StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(100)]
        public string Capital { get; set; }

        [StringLength(255)]
        public string FlagImageURL { get; set; }

        // Navigation
        public virtual ICollection<Sight> Sights { get; set; }
    }
}

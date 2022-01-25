using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GoogleLocations.Models
{
    public class PointOfInterest
    {
        [Key]
        public int LocationId { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Name of location")]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Address { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(50)]
        [Required]
        public string State { get; set; }

        [MinLength(6)]
        [MaxLength(6)]
        [Required]
        public int ZIP { get; set; }
    }
}

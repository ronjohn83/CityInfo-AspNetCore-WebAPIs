using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class PointsOfInterestForCreationDto
    {
        [Required(ErrorMessage ="You should provide a name value")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)] 
        public string Description { get; set; }
    }
}

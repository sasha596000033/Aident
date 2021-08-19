using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarStore.Models.Entity
{
    public class CarFeaturesEntity
    {
        [Key]
        public int Id { get; set; }
        public string Features { get; set; }
        public ICollection<CarDescriptionEntity> CarDescriptions { get; set; }
    }
}

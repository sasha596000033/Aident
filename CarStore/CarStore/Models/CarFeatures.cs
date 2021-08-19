using System.Collections.Generic;

namespace CarStore.Models
{
    public class CarFeatures
    {
        public int Id { get; set; }
        public string Features { get; set; }
        public ICollection<CarDescription> CarDescriptions { get; set; }
    }
}
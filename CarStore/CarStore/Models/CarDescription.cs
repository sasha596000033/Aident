using CarStore.Models.Enums;
using System;
using System.Collections.Generic;

namespace CarStore.Models
{
    public class CarDescription
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public ICollection<CarFeatures> CarFeatures { get; set; }
    }

    public class DescriptionFeatures
    {
        public int CarDescriptionId { get; set; }
        public CarDescription CarDescription { get; set; }
        public int CarFeaturesId { get; set; }
        public CarFeatures CarFeatures { get; set; }
    }
}
using CarStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarStore.Models.Entity
{
    public class CarDescriptionEntity
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public List<CarFeaturesEntity> CarFeatures { get; set; }
    }

    public class DescriptionFeaturesEntity
    {
        [Key]
        public int Id { get; set; }
        public int CarDescriptionId { get; set; }
        public CarDescriptionEntity CarDescription { get; set; }
        public int CarFeaturesId { get; set; }
        public CarFeaturesEntity CarFeatures { get; set; }
    }
}
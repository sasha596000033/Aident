using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public interface ICarFeaturesService
    {
        Task AddCarFeatures(CarFeatures carFeatures);
        Task DeleteCarFeatures(int id);
        Task<CarFeatures> GetCarFeatures(int id);
        Task UpdateCarFeatures(CarFeatures carFeatures);
    }
}

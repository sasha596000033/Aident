using CarStore.Models;
using CarStore.Repositories;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public class CarFeaturesService : ICarFeaturesService
    {
        private readonly ICrud<CarFeatures> _statement;

        public CarFeaturesService(ICrud<CarFeatures> statement)
        {
            _statement = statement;
        }

        public async Task AddCarFeatures(CarFeatures carFeatures)
        {
            await _statement.Create(carFeatures);
        }

        public async Task DeleteCarFeatures(int id)
        {
            await _statement.Delete(id);
        }

        public async Task<CarFeatures> GetCarFeatures(int id)
        {
            return await _statement.GetById(id);
        }

        public async Task UpdateCarFeatures(CarFeatures carFeatures)
        {
            await _statement.Update(carFeatures);
        }
    }
}
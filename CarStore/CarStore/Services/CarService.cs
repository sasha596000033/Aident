using CarStore.Models;
using CarStore.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public class CarService : ICarService
    {
        private readonly ICrud<CarDescription> _statement;

        public CarService(ICrud<CarDescription> statement)
        {
            _statement = statement;
        }

        public async Task AddCar(CarDescription carDescription)
        {
            await _statement.Create(carDescription);
        }

        public async Task DeleteCar(int id)
        {
            await _statement.Delete(id);
        }

        public async Task<IEnumerable<CarDescription>> GetAllCar()
        {
            return await _statement.GetAll();
        }

        public async Task<CarDescription> GetCar(int id)
        {
            return await _statement.GetById(id);
        }

        public async Task Update(CarDescription carDescription)
        {
            await _statement.Update(carDescription);
        }
    }
}
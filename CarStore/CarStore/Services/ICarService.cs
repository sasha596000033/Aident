using CarStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public interface ICarService
    {
        Task AddCar(CarDescription carDescription);
        Task<CarDescription> GetCar(int id);
        Task DeleteCar(int id);
        Task<IEnumerable<CarDescription>> GetAllCar();
        Task Update(CarDescription carDescription);
    }
}
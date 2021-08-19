using CarStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarStore.Repositories
{
    public interface ICrud<T>
    {
        Task Create(T _object);
        Task<T> GetById(int Id);
        Task Delete(int Id);
        Task Update(T _object);
        Task<IEnumerable<T>> GetAll();
    }
}
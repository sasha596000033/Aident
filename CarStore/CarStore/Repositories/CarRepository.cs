using CarStore.Connection;
using CarStore.Mappers;
using CarStore.Models;
using CarStore.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Repositories
{
    public class CarRepository : ICrud<CarDescription>
    {
        private readonly ApplicationDbContext _dbContext;

        public CarRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(CarDescription _object)
        {
            await _dbContext.AddAsync<CarDescriptionEntity>(_object.AsEntity());
            await _dbContext.SaveChangesAsync();

            foreach (var item in _object.CarFeatures)
            {
                var features = new DescriptionFeatures
                {
                    CarDescriptionId = _object.Id,
                    CarFeaturesId = item.Id
                };

                await _dbContext.AddAsync<DescriptionFeaturesEntity>(features.AsEntity());
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var statement = await _dbContext.CarDescriptions
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            _dbContext.Remove(statement);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarDescription>> GetAll()
        {
            var statements = await _dbContext.CarDescriptions.ToListAsync();
            return statements.AsDomain();
        }

        public async Task<CarDescription> GetById(int id)
        {
            var statement = await _dbContext.CarDescriptions
                .Where(x => x.Id == id)
                .Include(x => x.CarFeatures)
                .FirstOrDefaultAsync();

            return statement.AsDomain();
        }

        public async Task Update(CarDescription _object)
        {
            var statement = await _dbContext.CarDescriptions
                .Where(x => x.Id == _object.Id)
                .FirstOrDefaultAsync();

            statement.Image = _object.Image;
            statement.Model = _object.Model;
            statement.Price = _object.Price;
            statement.Year = _object.Year;
            statement.Description = _object.Description;
            statement.Currency = _object.Currency;

            await _dbContext.SaveChangesAsync();
            //statement.CarFeatures
        }
    }
}
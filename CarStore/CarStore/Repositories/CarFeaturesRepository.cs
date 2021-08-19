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
    public class CarFeaturesRepository : ICrud<CarFeatures>
    {
        private readonly ApplicationDbContext _dbContext;

        public CarFeaturesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(CarFeatures _object)
        {
            try
            {
                await _dbContext.AddAsync<CarFeaturesEntity>(_object.AsEntity());
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var statement = await _dbContext.CarFeatures
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync();

                _dbContext.Remove(statement);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<CarFeatures>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CarFeatures> GetById(int id)
        {
            var statement = await _dbContext.CarFeatures
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return statement.AsDomain();
        }

        public async Task Update(CarFeatures _object)
        {
            var statement = await _dbContext.CarFeatures.FindAsync(_object.Id);

            statement.Features = _object.Features;
            await _dbContext.SaveChangesAsync();
        }
    }
}
using CarStore.Models;
using CarStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarFeaturesController : ControllerBase
    {
        private readonly ILogger<CarFeaturesController> _logger;
        private readonly ICarFeaturesService _carFeatures;

        public CarFeaturesController(ILogger<CarFeaturesController> logger, ICarFeaturesService carFeatures)
        {
            _carFeatures = carFeatures;
            _logger = logger;
        }

        [HttpPost]
        public async Task CreateCarFeatures(CarFeatures carFeatures)
        {
            try
            {
                await _carFeatures.AddCarFeatures(carFeatures);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task DeleteCarFeatures(int id)
        {
            try
            {
                await _carFeatures.DeleteCarFeatures(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<CarFeatures> GetCarFeatures(int id)
        {
            try
            {
                return await _carFeatures.GetCarFeatures(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task UpdateCarFeatures(CarFeatures carFeatures)
        {
            try
            {
                await _carFeatures.UpdateCarFeatures(carFeatures);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
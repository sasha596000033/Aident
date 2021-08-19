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
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _carService = carService;
            _logger = logger;
        }

        [HttpPost]
        public async Task CreateCarDescription(CarDescription carDescription)
        {
            try
            {
                await _carService.AddCar(carDescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<CarDescription> GetCarDescription(int id)
        {
            try
            {
                return await _carService.GetCar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task DeleteCarDescription(int id)
        {
            try
            {
                await _carService.DeleteCar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task UpdateCarDescription(CarDescription carDescription)
        {
            try
            {
                await _carService.Update(carDescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
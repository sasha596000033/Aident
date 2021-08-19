using CarStore.Models;
using CarStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICarService _carService;
        private readonly ICarFeaturesService _carFeatures;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICarService carService, ICarFeaturesService carFeatures)
        {
            _carFeatures = carFeatures;
            _carService = carService;
            _logger = logger;
        }

        //[HttpPost]
        //public async Task Create(CarDescription carDescription)
        //{
        //    await _carService.AddCar(carDescription);
        //}
    }
}
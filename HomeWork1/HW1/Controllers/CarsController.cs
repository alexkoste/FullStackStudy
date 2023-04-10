using HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> Get()
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Ford", "Focus", 2011, "USA"));
            cars.Add(new Car("Mazda", "Cx-5", 2011, "Japan"));
            cars.Add(new Car("KIA", "CEED", 2009, "Korea"));

            return cars;
        }
    }
}

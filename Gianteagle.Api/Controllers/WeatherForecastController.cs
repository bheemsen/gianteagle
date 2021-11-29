using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gianteagle.BAL.IServices;

namespace Gianteagle.Api.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserService userService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserService _userSevice)
        {
            _logger = logger;
            this.userService = _userSevice;
        }

        [HttpGet]        
        [Route("samp")]
        public IEnumerable<WeatherForecast> Get()
         {
            _logger.Log(LogLevel.Information, "AAAAAAAAA");
             var users = userService.AddUser(new Entities.User());
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

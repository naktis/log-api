using LogApi.Dto;
using LogApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ServiceFactory _serviceFactory;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<LoggerOptions> options)
        {
            _logger = logger;
            _serviceFactory = new ServiceFactory(options.Value.Destination);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public ActionResult<LogDto> PostLog([FromBody] LogDto request)
        {

            IService service = _serviceFactory.GetService();

            service.Create(request);


            return Ok(); //nameof(PostLog), request);
        }




        // Factory usage example, delete later
        //[HttpGet("{key}")]
        //public string AmIJaredNineteenWhoNeverLearnedHowToRead(int id)
        //{
        //    IService service = _serviceFactory.GetService();

        //    if (!service.ReadsAllowed())
        //        return "It's Jared, can't read (something isn't working)";

        //    return "Not Jared, can read (success)";
        //}


    }
}

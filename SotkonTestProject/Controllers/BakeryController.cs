using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SotkonTestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {
        public BakeryController()
        {
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //         {
        //             Date = DateTime.Now.AddDays(index),
        //             TemperatureC = rng.Next(-20, 55),
        //             Summary = Summaries[rng.Next(Summaries.Length)]
        //         })
        //         .ToArray();
        // }
    }
}
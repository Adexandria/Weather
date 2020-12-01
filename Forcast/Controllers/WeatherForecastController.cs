using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Forcast.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Forcast.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeather weather;
        private readonly IMapper mapper;
        public WeatherForecastController(IWeather weather, IMapper mapper)
        {
            this.weather = weather;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var forecast = weather.Weathers;
            var newforcast = mapper.Map<IEnumerable<WeatherDTO>>(forecast);
            return Ok(newforcast);
        }
    }
}

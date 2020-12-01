using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forcast
{
    public class WeatherProfile :Profile
    {
        public WeatherProfile()
        {
            CreateMap<WeatherDTO, WeatherForecast>();

        }
    }
}

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
            CreateMap<WeatherForecast, WeatherDTO>()
                .ForMember(dest=>dest.Summary,opt=>opt.MapFrom(src=>src.Summary))
                .ForMember(dest => dest.TemperatureC, opt => opt.MapFrom(src => src.TemperatureC))
                .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => src.TemperatureF))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date));

        }
    }
}

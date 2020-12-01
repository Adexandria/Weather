using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forcast.Services
{
    public interface IWeather
    {
        IEnumerable<WeatherForecast> Weathers { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forcast.Services
{
    public class Weather :IWeather
    {
        private readonly DbServices db;
        public Weather(DbServices db)
        {
            this.db = db;
        }
        public IEnumerable<WeatherForecast> Weathers 
        {
            get
            {
                return db.forecasts.OrderBy(r => r.Date);
            }
        }

    }
}

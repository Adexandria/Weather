using Forcast;
using Forcast.Services;
using System;
using Xunit;

namespace Weathertest
{
    public class UnitTest1:IDisposable
    {
        WeatherForecast weather;

        public UnitTest1()
        {
             weather = new WeatherForecast()
            {
                Id=new Guid("353160ff-5043-42be-8289-3fc31e77e8ba"),
                Date = new DateTime(0000 - 00 - 00),
                TemperatureC=00,
                Summary="This is just testing"
                
            };

        }

        public void Dispose()
        {
            weather = null;
        }

        [Fact]
        public void Test1()
        {
            weather.TemperatureC = 40;
            Assert.Equal(40, weather.TemperatureC);
        }

    }
}

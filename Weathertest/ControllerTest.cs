using AutoMapper;
using Forcast;
using Forcast.Controllers;
using Forcast.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Weathertest
{
   public  class ControllerTest :IDisposable
    {
        Mock<IWeather> mockrepo;
        IMapper mapper;
        MapperConfiguration configuration;
        WeatherProfile profile;
        public ControllerTest()
        {
            mockrepo = new Mock<IWeather>();
            profile = new WeatherProfile();
            configuration = new MapperConfiguration(c => c.AddProfile(profile));
            mapper = new Mapper(configuration);
        }

        public void Dispose()
        {
            mockrepo = null;
            profile = null;
            configuration = null;
            mapper = null;
        }

        [Fact]
        public void Testing()
        {
            mockrepo.Setup(s => s.Weathers);
            var weather = new WeatherForecastController(mockrepo.Object,mapper);
            var result = weather.Get();
            Assert.IsType<OkObjectResult>(result);
        }
    }
}

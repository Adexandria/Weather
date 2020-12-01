using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forcast.Services
{
    public class DbServices: DbContext 
    {
        public DbServices(DbContextOptions<DbServices> options):base(options)
        {

        }
       public DbSet<WeatherForecast> forecasts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFinder
{
    class WeatherDetails
    {
        public class coord
        {
            // from coord.lon
            public double lon { get; set; }
            // from coord.lat
            public double lat { get; set; }
        }

        public class weather
        {
            // from weather.main
            public string main { get; set; }
            // from weather.description
            public string description { get; set; }
            // from weather.icon
            public string icon { get; set; }
        }

        public class main
        {
            // from main.temp
            public double temp { get; set; }
            //from main.pressure
            public double pressure { get; set; }
            // from main.humidity
            public double humidity { get; set; }
            // from main.feels_like
            public double feels_like { get; set; }
        }

        public class wind
        {
            // from wind.speed
            public double speed { get; set; }
        }

        public class sys
        {
            // from sys.sunrise
            public long sunrise { get; set; }
            // from sys.sunset
            public long sunset { get; set; }
        }

        public class result
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }

}

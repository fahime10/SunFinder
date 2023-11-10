using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFinder
{
    class WeatherDetails
    {
        public class coordinates
        {
            // from coord.lon
            double longitude { get; set; }
            // from coord.lat
            double latitude { get; set; }
        }

        public class weather
        {
            // from weather.main
            string curr_weather { get; set; }
            // from weather.description
            string description { get; set; }
            // from weather.icon
            string image_link { get; set; }
        }

        public class main_info
        {
            // from main.temp
            double temperature { get; set; }
            //from main.pressure
            double pressure { get; set; }
            // from main.humidity
            double humidity { get; set; }
            // from main.feels_like
            double feels_like { get; set; }
        }

        public class wind
        {
            // from wind.speed
            double speed { get; set; }
        }

        public class system
        {
            // from sys.sunrise
            long sunrise { get; set; }
            // from sys.sunset
            long sunset { get; set; }
        }

        public class main
        {
            public coordinates coord { get; set; }
            public List<weather> weather { get; set; }
            public main_info info { get; set; }
            public wind wind { get; set; }
        }
    }

}

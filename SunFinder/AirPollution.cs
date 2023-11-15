using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFinder
{
    class AirPollution
    {
        public class main
        {
            public int aqi { get; set; }
        }

        public class components
        {
            public double co { get; set; }
            public double no { get; set; }
            public double no2 { get; set; }
            public double o3 { get; set; }
            public double so2 { get; set; }
        }

        public class list
        {
            public main main { get; set; }
            public components components { get; set; }
        }

        public class air
        {
            public List<list> list { get; set; }
        }

        public string pollution(int main)
        {
            switch (main)
            {
                case 1:
                    return "Low pollution - Good";

                case 2:
                    return "Some pollution - Fair";

                case 3:
                    return "Moderate pollution";

                case 4:
                    return "High pollution - Poor";

                case 5:
                    return "Very high pollution - Very poor";

                default:
                    return "Unknown";
            }
        } 
    }
}

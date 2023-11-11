using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace SunFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string APIkey = "cf20561ce137565baf710599e21bc9be";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient client = new WebClient())
            {
                string url = string.Format(
                    "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",
                    txtBoxCity.Text,
                    APIkey
                 );

                var jsonOutput = client.DownloadString(url);

                WeatherDetails.result details = 
                    JsonConvert.DeserializeObject<WeatherDetails.result>(jsonOutput);

                pictureImage.ImageLocation = 
                    "https://openweathermap.org/img/w/" + details.weather[0].icon + ".png";
                labelCondition.Text = details.weather[0].main;
                labelDetails.Text = details.weather[0].description;

                labelHumidity.Text = details.main.humidity.ToString() + " %";
                labelTemperature.Text = 
                    convertKelvinToCelsius(details.main.temp).ToString() + " °C";
                labelFeelsLike.Text = 
                    convertKelvinToCelsius(details.main.feels_like).ToString() + " °C";

                labelSunrise.Text = convertDT(details.sys.sunrise).ToShortTimeString();
                labelSunset.Text = convertDT(details.sys.sunset).ToShortTimeString();

                labelWindSpeed.Text = details.wind.speed.ToString() + " m/s";
                labelPressure.Text = 
                    details.main.pressure.ToString() + " hPa (hectopascals)";

                labelLocationName.Text = txtBoxCity.Text;
            }
        }

        DateTime convertDT(long sec)
        {
            // (year, month, day, hours, mins, seconds, millisec, ...)
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime result = day.AddSeconds(sec).ToLocalTime();

            return result;
        }

        double convertKelvinToCelsius(double temp)
        {
            double result = temp - 273.15;
            return Math.Round(result, 2);
        }
    }
}

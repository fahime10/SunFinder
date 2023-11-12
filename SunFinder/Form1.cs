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
using System.Device.Location;

namespace SunFinder
{
    public partial class Form1 : Form
    {
        private GeoCoordinateWatcher geoWatcher;
        public Form1()
        {
            InitializeComponent();
            GeoWatcher();
        }

        private void GeoWatcher()
        {
            geoWatcher = new GeoCoordinateWatcher();
            geoWatcher.PositionChanged += positionChanged;
        }

        private void positionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            var latitude = e.Position.Location.Latitude;
            var longitude = e.Position.Location.Longitude;

            MessageBox.Show($"Latitude: {latitude}, Longitude: {longitude}");
        }
        private void btnCurr_Click(object sender, EventArgs e)
        {
            if (geoWatcher.Status == GeoPositionStatus.Ready)
            {
                geoWatcher.Start();
            }
            else
            {
                MessageBox.Show("Geolocation not available or not ready.");
            }
        }

        readonly string APIkey = "cf20561ce137565baf710599e21bc9be";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            useWeatherAPI();
        }

        void useWeatherAPI()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = string.Format(
                        "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",
                        txtBoxCity.Text.Substring(0, 1).ToUpper() + txtBoxCity.Text.Substring(1),
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

                    labelLocationName.Text =
                        txtBoxCity.Text.Substring(0, 1).ToUpper() + txtBoxCity.Text.Substring(1);
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
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

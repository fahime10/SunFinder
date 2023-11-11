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

        string APIkey = "cf20561ce137565baf710599e21bc9be";

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

                labelHumidity.Text = details.main.humidity.ToString();
                labelTemperature.Text = details.main.temp.ToString();
                labelFeelsLike.Text = details.main.feels_like.ToString();

                labelSunrise.Text = details.sys.sunrise.ToString();
                labelSunset.Text = details.sys.sunset.ToString();

                labelWindSpeed.Text = details.wind.speed.ToString();
                labelPressure.Text = details.main.pressure.ToString();

                labelCityName.Text = txtBoxCity.Text;
            }
        }
    }
}

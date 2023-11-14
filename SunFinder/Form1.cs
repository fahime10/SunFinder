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
        private bool isCelsius = true;

        // Light mode colors
        Color lightBackColor = Color.CadetBlue;
        Color lightForeColor = Color.Black;

        // Dark mode colors
        Color darkBackColor = Color.FromArgb(31, 31, 31);
        Color darkForeColor = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void ApplyColorScheme(bool isDarkMode, Control control)
        {
            if (isDarkMode)
            {
                control.BackColor = darkBackColor;
                control.ForeColor = darkForeColor;
                btnMode.Text = "Dark Mode";
            } 
            else
            {
                control.BackColor = lightBackColor;
                control.ForeColor = lightForeColor;
                btnMode.Text = "Light Mode";
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyColorScheme(isDarkMode, childControl);
            }
        }

        private void ToggleDarkMode()
        {
            Properties.Settings.Default.DarkMode = !Properties.Settings.Default.DarkMode;

            ApplyColorScheme(Properties.Settings.Default.DarkMode, this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        readonly string APIkey = "cf20561ce137565baf710599e21bc9be";

        private void btnSearch_Click(object sender, EventArgs e)
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
                        convertKelvinToCelsius(details.main.temp).ToString();
                    labelFeelsLike.Text =
                        convertKelvinToCelsius(details.main.feels_like).ToString();

                    labelSunrise.Text = convertDT(details.sys.sunrise).ToShortTimeString();
                    labelSunset.Text = convertDT(details.sys.sunset).ToShortTimeString();

                    labelWindSpeed.Text = details.wind.speed.ToString() + " m/s";
                    labelPressure.Text =
                        details.main.pressure.ToString() + " hPa (hectopascals)";

                    labelLocationName.Text =
                        txtBoxCity.Text.Substring(0, 1).ToUpper() + txtBoxCity.Text.Substring(1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a sensible city", "Error");
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

        private void btnToF_Click(object sender, EventArgs e)
        {
            tempConverter();
        }

        void tempConverter()
        {
            try
            {
                double valueTemp = Convert.ToDouble(labelTemperature.Text);
                double valueFeels = Convert.ToDouble(labelFeelsLike.Text);

                if (isCelsius)
                {
                    valueTemp = (valueTemp * 9 / 5) + 32;
                    valueFeels = (valueFeels * 9 / 5) + 32;
                    isCelsius = false;
                    btnConverter.Text = "To °C";
                    labelUnit1.Text = "°F";
                    labelUnit2.Text = "°F";
                } 
                else
                {
                    valueTemp = (valueTemp - 32) * 5 / 9;
                    valueFeels = (valueFeels - 32) * 5 / 9;
                    isCelsius = true;
                    btnConverter.Text = "To °F";
                    labelUnit1.Text = "°C";
                    labelUnit2.Text = "°C";
                }

                labelTemperature.Text = valueTemp.ToString();
                labelFeelsLike.Text = valueFeels.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show($"Please input a city first", "Error");
            }
        }
    }
}

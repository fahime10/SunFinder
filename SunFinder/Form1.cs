using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace SunFinder
{
    public partial class Form1 : Form
    {
        private bool isCelsius = true;
        private double lon;
        private double lat;

        // Light mode colors
        private readonly Color lightForeColor = Color.Black;

        // Dark mode colors
        private readonly Color darkForeColor = Color.White;

        // Images readily available, so switching modes is smoother
        private readonly Image darkModeBackground = Properties.Resources.DarkModeBackground;
        private readonly Image lightModeBackground = Properties.Resources.LightModeBackground;

        public Form1()
        {
            InitializeComponent();
        }

        private void ApplyColorScheme(bool isDarkMode, Control control)
        {
            if (isDarkMode)
            {
                control.ForeColor = darkForeColor;
                btnMode.Text = "Dark Mode";
                this.BackgroundImage = darkModeBackground;
            } 
            else
            {
                control.ForeColor = lightForeColor;
                btnMode.Text = "Light Mode";
                this.BackgroundImage = lightModeBackground;
            }

            foreach (Control childControl in control.Controls)
            {
                if (!(childControl is Button) && !(childControl is TextBox))
                {
                    ApplyColorScheme(isDarkMode, childControl);
                }
            }
        }

        private void ToggleDarkMode()
        {
            Properties.Settings.Default.DarkMode = !Properties.Settings.Default.DarkMode;

            // DarkMode initially set to false
            ApplyColorScheme(Properties.Settings.Default.DarkMode, this);
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        readonly string APIKey = "cf20561ce137565baf710599e21bc9be";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCity.Text == "")
                {
                    throw new Exception();
                }

                using (WebClient client = new WebClient())
                {
                    string url = string.Format(
                        "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",
                        txtBoxCity.Text.Substring(0, 1).ToUpper() + txtBoxCity.Text.Substring(1),
                        APIKey
                     );

                    var jsonOutput = client.DownloadString(url);

                    WeatherDetails.result details =
                        JsonConvert.DeserializeObject<WeatherDetails.result>(jsonOutput);

                    pictureImage.ImageLocation =
                        "https://openweathermap.org/img/w/" + details.weather[0].icon + ".png";
                    labelCondition.Text = details.weather[0].main;
                    labelDetails.Text = 
                        details.weather[0].description.Substring(0, 1).ToUpper() + 
                        details.weather[0].description.Substring(1);

                    labelHumidity.Text = details.main.humidity.ToString() + " %";

                    Converter converter = new Converter();
                    labelTemperature.Text = converter.ConvertKToC(details.main.temp).ToString();
                    labelFeelsLike.Text = converter.ConvertKToC(details.main.feels_like).ToString();

                    labelSunrise.Text = converter.ConvertDT(details.sys.sunrise).ToShortTimeString();
                    labelSunset.Text = converter.ConvertDT(details.sys.sunset).ToShortTimeString();

                    labelWindSpeed.Text = details.wind.speed.ToString() + " m/s";
                    labelPressure.Text =
                        details.main.pressure.ToString() + " hPa (hectopascals)";

                    labelLocationName.Text =
                        txtBoxCity.Text.Substring(0, 1).ToUpper() + txtBoxCity.Text.Substring(1);

                    lon = details.coord.lon;
                    lat = details.coord.lat;
                }

                using (WebClient client2 = new WebClient())
                {
                    string url2 = string.Format(
                        "http://api.openweathermap.org/data/2.5/air_pollution?lat={0}&lon={1}&appid={2}",
                        lat, 
                        lon,
                        APIKey
                     );

                    var jsonOutput2 = client2.DownloadString(url2);

                    AirPollution.air airDetails =
                        JsonConvert.DeserializeObject<AirPollution.air>(jsonOutput2);

                    AirPollution measurer = new AirPollution();

                    labelAirPollution.Text = measurer.Pollution(airDetails.list[0].main.aqi);

                    labelCO.Text = airDetails.list[0].components.co.ToString();
                    labelNO.Text = airDetails.list[0].components.no.ToString();
                    labelNO2.Text = airDetails.list[0].components.no2.ToString();
                    labelO3.Text = airDetails.list[0].components.o3.ToString();
                    labelSO2.Text = airDetails.list[0].components.co.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a sensible city", "Error");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                txtBoxCity.Text = "";
            }
        }

        private void btnToF_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            converter.TempConverter(isCelsius, labelTemperature,  labelFeelsLike, btnConverter,
                labelUnit1, labelUnit2);

            isCelsius = !isCelsius;
        }
    }
}

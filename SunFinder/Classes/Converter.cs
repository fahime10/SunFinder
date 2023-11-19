using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunFinder
{
    class Converter
    {
        // Convert DateTime from (long) type seconds to local time
        public DateTime ConvertDT(long sec)
        {

            // (year, month, day, hours, mins, seconds, millisec, ...)
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            DateTime result = day.AddSeconds(sec).ToLocalTime();

            return result;
        }

        // Convert from Kelvin to Celsius
        public double ConvertKToC(double temp)
        {
            double result = temp - 273.15;
            return Math.Round(result, 2);
        }

        // Convert from Celsius to Farenheit and vicersa.
        // Also, modify the label and button texts.
        public void TempConverter(bool isCelsius, Label labelTemperature, Label labelFeelsLike, 
            Button btnConverter, Label labelUnit1, Label labelUnit2)
        {
            try
            {
                double valueTemp = Convert.ToDouble(labelTemperature.Text);
                double valueFeels = Convert.ToDouble(labelFeelsLike.Text);

                if (isCelsius)
                {
                    valueTemp = (valueTemp * 9 / 5) + 32;
                    valueFeels = (valueFeels * 9 / 5) + 32;
                    btnConverter.Text = "To °C";
                    labelUnit1.Text = "°F";
                    labelUnit2.Text = "°F";
                }
                else
                {
                    valueTemp = (valueTemp - 32) * 5 / 9;
                    valueFeels = (valueFeels - 32) * 5 / 9;
                    btnConverter.Text = "To °F";
                    labelUnit1.Text = "°C";
                    labelUnit2.Text = "°C";
                }

                labelTemperature.Text = valueTemp.ToString();
                labelFeelsLike.Text = valueFeels.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please input a city first", "Error");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace SunFinder.UnitTests
{
    [TestClass]
    public class ConverterTestClass
    {
        // Test data to be used
        double kelvinTemp = 300.0;
        bool isCelsius = true;
        Label dummyLabel = new Label();
        Button dummyButton = new Button();

        // First test check
        [TestMethod]
        public void OK()
        {
            bool ok = true;
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void InstanceOK()
        {
            Converter converter = new Converter();
            Assert.IsNotNull(converter);
        }

        // Test the normal working of converting from Kelvin to Celsius degree
        [TestMethod]
        public void TestConvertKToC()
        {
            double result;
            Converter converter = new Converter();
            result = converter.ConvertKToC(kelvinTemp);
            Assert.AreEqual(26.85, result);
        }

        // Test conversion from Celsius to Farenheit
        [TestMethod]
        public void TestTempConverterCToF()
        {
            Label label = new Label();
            label.Text = (20.0).ToString();

            double result;
            Converter converter = new Converter();
            converter.TempConverter(isCelsius, label, label, dummyButton, dummyLabel, dummyLabel);

            result = Convert.ToDouble(label.Text);

            Assert.AreEqual(68.0, result);
        }

        // Test conversion from Farenheit to Celsius
        [TestMethod]
        public void TestTempConverterFToC()
        {
            isCelsius = false;
            Label label = new Label();
            label.Text = (104.0).ToString();

            double result;
            Converter converter = new Converter();
            converter.TempConverter(isCelsius, label, label, dummyButton, dummyLabel, dummyLabel);

            result = Convert.ToDouble(label.Text);

            Assert.AreEqual(40.0, result);
        }

        // Test to check the correct time is displayed
        [TestMethod]
        public void TestConvertDT()
        {
            long sunrise = 1700205681;
            long sunset = 1700237381;

            Converter converter = new Converter();

            string sunriseResult = converter.ConvertDT(sunrise).ToShortTimeString();
            string sunsetResult = converter.ConvertDT(sunset).ToShortTimeString();

            Assert.AreEqual("07:21", sunriseResult);
            Assert.AreEqual("16:09", sunsetResult);
        }
    }
}

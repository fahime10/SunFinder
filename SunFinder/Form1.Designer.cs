namespace SunFinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLocation = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSunriseInfo = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunsetInfo = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelWindSpeedInfo = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelPressureInfo = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.labelHumidityInfo = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelTemperatureInfo = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelFeelsLikeInfo = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.labelUnit1 = new System.Windows.Forms.Label();
            this.labelUnit2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelCurrentWeather = new System.Windows.Forms.Label();
            this.labelLocationName = new System.Windows.Forms.Label();
            this.labelAirPollutionInfo = new System.Windows.Forms.Label();
            this.labelAirPollution = new System.Windows.Forms.Label();
            this.labelCOInfo = new System.Windows.Forms.Label();
            this.labelCO = new System.Windows.Forms.Label();
            this.labelNOInfo = new System.Windows.Forms.Label();
            this.labelNO = new System.Windows.Forms.Label();
            this.labelNO2Info = new System.Windows.Forms.Label();
            this.labelNO2 = new System.Windows.Forms.Label();
            this.labelO3Info = new System.Windows.Forms.Label();
            this.labelO3 = new System.Windows.Forms.Label();
            this.labelSO2Info = new System.Windows.Forms.Label();
            this.labelSO2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.Black;
            this.labelLocation.Location = new System.Drawing.Point(20, 33);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(236, 32);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location (by city):";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.BackColor = System.Drawing.Color.Azure;
            this.txtBoxCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(274, 34);
            this.txtBoxCity.MaxLength = 58;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(487, 39);
            this.txtBoxCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(776, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.Black;
            this.labelDetails.Location = new System.Drawing.Point(307, 301);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(102, 32);
            this.labelDetails.TabIndex = 4;
            this.labelDetails.Text = "Details";
            // 
            // labelSunriseInfo
            // 
            this.labelSunriseInfo.AutoSize = true;
            this.labelSunriseInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelSunriseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseInfo.ForeColor = System.Drawing.Color.Black;
            this.labelSunriseInfo.Location = new System.Drawing.Point(658, 235);
            this.labelSunriseInfo.Name = "labelSunriseInfo";
            this.labelSunriseInfo.Size = new System.Drawing.Size(111, 32);
            this.labelSunriseInfo.TabIndex = 5;
            this.labelSunriseInfo.Text = "Sunrise";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.ForeColor = System.Drawing.Color.Black;
            this.labelSunrise.Location = new System.Drawing.Point(837, 235);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(61, 32);
            this.labelSunrise.TabIndex = 6;
            this.labelSunrise.Text = "N/A";
            // 
            // labelSunsetInfo
            // 
            this.labelSunsetInfo.AutoSize = true;
            this.labelSunsetInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelSunsetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetInfo.ForeColor = System.Drawing.Color.Black;
            this.labelSunsetInfo.Location = new System.Drawing.Point(658, 301);
            this.labelSunsetInfo.Name = "labelSunsetInfo";
            this.labelSunsetInfo.Size = new System.Drawing.Size(103, 32);
            this.labelSunsetInfo.TabIndex = 7;
            this.labelSunsetInfo.Text = "Sunset";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.Color.Black;
            this.labelSunset.Location = new System.Drawing.Point(837, 301);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(61, 32);
            this.labelSunset.TabIndex = 8;
            this.labelSunset.Text = "N/A";
            // 
            // labelWindSpeedInfo
            // 
            this.labelWindSpeedInfo.AutoSize = true;
            this.labelWindSpeedInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedInfo.ForeColor = System.Drawing.Color.Black;
            this.labelWindSpeedInfo.Location = new System.Drawing.Point(657, 373);
            this.labelWindSpeedInfo.Name = "labelWindSpeedInfo";
            this.labelWindSpeedInfo.Size = new System.Drawing.Size(170, 32);
            this.labelWindSpeedInfo.TabIndex = 9;
            this.labelWindSpeedInfo.Text = "WindSpeed:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.labelWindSpeed.Location = new System.Drawing.Point(837, 373);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(61, 32);
            this.labelWindSpeed.TabIndex = 10;
            this.labelWindSpeed.Text = "N/A";
            // 
            // labelPressureInfo
            // 
            this.labelPressureInfo.AutoSize = true;
            this.labelPressureInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPressureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureInfo.ForeColor = System.Drawing.Color.Black;
            this.labelPressureInfo.Location = new System.Drawing.Point(657, 444);
            this.labelPressureInfo.Name = "labelPressureInfo";
            this.labelPressureInfo.Size = new System.Drawing.Size(135, 32);
            this.labelPressureInfo.TabIndex = 11;
            this.labelPressureInfo.Text = "Pressure:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.Transparent;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.ForeColor = System.Drawing.Color.Black;
            this.labelPressure.Location = new System.Drawing.Point(837, 444);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(61, 32);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "N/A";
            // 
            // pictureImage
            // 
            this.pictureImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureImage.Location = new System.Drawing.Point(-1, 84);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(399, 214);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImage.TabIndex = 13;
            this.pictureImage.TabStop = false;
            // 
            // labelHumidityInfo
            // 
            this.labelHumidityInfo.AutoSize = true;
            this.labelHumidityInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityInfo.ForeColor = System.Drawing.Color.Black;
            this.labelHumidityInfo.Location = new System.Drawing.Point(72, 373);
            this.labelHumidityInfo.Name = "labelHumidityInfo";
            this.labelHumidityInfo.Size = new System.Drawing.Size(140, 32);
            this.labelHumidityInfo.TabIndex = 14;
            this.labelHumidityInfo.Text = "Humidity: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.ForeColor = System.Drawing.Color.Black;
            this.labelHumidity.Location = new System.Drawing.Point(307, 373);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(132, 32);
            this.labelHumidity.TabIndex = 15;
            this.labelHumidity.Text = "Unknown";
            // 
            // labelTemperatureInfo
            // 
            this.labelTemperatureInfo.AutoSize = true;
            this.labelTemperatureInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperatureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureInfo.ForeColor = System.Drawing.Color.Black;
            this.labelTemperatureInfo.Location = new System.Drawing.Point(72, 444);
            this.labelTemperatureInfo.Name = "labelTemperatureInfo";
            this.labelTemperatureInfo.Size = new System.Drawing.Size(184, 32);
            this.labelTemperatureInfo.TabIndex = 16;
            this.labelTemperatureInfo.Text = "Temperature:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.Black;
            this.labelTemperature.Location = new System.Drawing.Point(307, 444);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(132, 32);
            this.labelTemperature.TabIndex = 17;
            this.labelTemperature.Text = "Unknown";
            // 
            // labelFeelsLikeInfo
            // 
            this.labelFeelsLikeInfo.AutoSize = true;
            this.labelFeelsLikeInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLikeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLikeInfo.ForeColor = System.Drawing.Color.Black;
            this.labelFeelsLikeInfo.Location = new System.Drawing.Point(658, 170);
            this.labelFeelsLikeInfo.Name = "labelFeelsLikeInfo";
            this.labelFeelsLikeInfo.Size = new System.Drawing.Size(143, 32);
            this.labelFeelsLikeInfo.TabIndex = 18;
            this.labelFeelsLikeInfo.Text = "Feels like:";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.ForeColor = System.Drawing.Color.Black;
            this.labelFeelsLike.Location = new System.Drawing.Point(837, 170);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(132, 32);
            this.labelFeelsLike.TabIndex = 20;
            this.labelFeelsLike.Text = "Unknown";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.Azure;
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.Black;
            this.btnMode.Location = new System.Drawing.Point(958, 34);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(151, 47);
            this.btnMode.TabIndex = 23;
            this.btnMode.Text = "Light Mode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.Azure;
            this.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.Black;
            this.btnConverter.Location = new System.Drawing.Point(485, 444);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(89, 45);
            this.btnConverter.TabIndex = 24;
            this.btnConverter.Text = "To °F";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnToF_Click);
            // 
            // labelUnit1
            // 
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.BackColor = System.Drawing.Color.Transparent;
            this.labelUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit1.ForeColor = System.Drawing.Color.Black;
            this.labelUnit1.Location = new System.Drawing.Point(434, 444);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(45, 32);
            this.labelUnit1.TabIndex = 25;
            this.labelUnit1.Text = "°C";
            // 
            // labelUnit2
            // 
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.BackColor = System.Drawing.Color.Transparent;
            this.labelUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit2.ForeColor = System.Drawing.Color.Black;
            this.labelUnit2.Location = new System.Drawing.Point(966, 170);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(45, 32);
            this.labelUnit2.TabIndex = 26;
            this.labelUnit2.Text = "°C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Description:";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.Black;
            this.labelCondition.Location = new System.Drawing.Point(307, 235);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(136, 32);
            this.labelCondition.TabIndex = 3;
            this.labelCondition.Text = "Condition";
            // 
            // labelCurrentWeather
            // 
            this.labelCurrentWeather.AutoSize = true;
            this.labelCurrentWeather.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentWeather.Location = new System.Drawing.Point(72, 235);
            this.labelCurrentWeather.Name = "labelCurrentWeather";
            this.labelCurrentWeather.Size = new System.Drawing.Size(216, 32);
            this.labelCurrentWeather.TabIndex = 28;
            this.labelCurrentWeather.Text = "Current weather";
            // 
            // labelLocationName
            // 
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationName.ForeColor = System.Drawing.Color.Black;
            this.labelLocationName.Location = new System.Drawing.Point(294, 84);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(173, 46);
            this.labelLocationName.TabIndex = 21;
            this.labelLocationName.Text = "Location";
            // 
            // labelAirPollutionInfo
            // 
            this.labelAirPollutionInfo.AutoSize = true;
            this.labelAirPollutionInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelAirPollutionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirPollutionInfo.ForeColor = System.Drawing.Color.Black;
            this.labelAirPollutionInfo.Location = new System.Drawing.Point(336, 561);
            this.labelAirPollutionInfo.Name = "labelAirPollutionInfo";
            this.labelAirPollutionInfo.Size = new System.Drawing.Size(183, 40);
            this.labelAirPollutionInfo.TabIndex = 29;
            this.labelAirPollutionInfo.Text = "Air Quality";
            // 
            // labelAirPollution
            // 
            this.labelAirPollution.AutoSize = true;
            this.labelAirPollution.BackColor = System.Drawing.Color.Transparent;
            this.labelAirPollution.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirPollution.ForeColor = System.Drawing.Color.Black;
            this.labelAirPollution.Location = new System.Drawing.Point(594, 561);
            this.labelAirPollution.Name = "labelAirPollution";
            this.labelAirPollution.Size = new System.Drawing.Size(167, 40);
            this.labelAirPollution.TabIndex = 30;
            this.labelAirPollution.Text = "Unknown";
            // 
            // labelCOInfo
            // 
            this.labelCOInfo.AutoSize = true;
            this.labelCOInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelCOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOInfo.ForeColor = System.Drawing.Color.Black;
            this.labelCOInfo.Location = new System.Drawing.Point(72, 698);
            this.labelCOInfo.Name = "labelCOInfo";
            this.labelCOInfo.Size = new System.Drawing.Size(313, 32);
            this.labelCOInfo.TabIndex = 31;
            this.labelCOInfo.Text = "Carbon Monoxide (CO):";
            // 
            // labelCO
            // 
            this.labelCO.AutoSize = true;
            this.labelCO.BackColor = System.Drawing.Color.Transparent;
            this.labelCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCO.ForeColor = System.Drawing.Color.Black;
            this.labelCO.Location = new System.Drawing.Point(421, 698);
            this.labelCO.Name = "labelCO";
            this.labelCO.Size = new System.Drawing.Size(132, 32);
            this.labelCO.TabIndex = 32;
            this.labelCO.Text = "Unknown";
            // 
            // labelNOInfo
            // 
            this.labelNOInfo.AutoSize = true;
            this.labelNOInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelNOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOInfo.ForeColor = System.Drawing.Color.Black;
            this.labelNOInfo.Location = new System.Drawing.Point(72, 784);
            this.labelNOInfo.Name = "labelNOInfo";
            this.labelNOInfo.Size = new System.Drawing.Size(279, 32);
            this.labelNOInfo.TabIndex = 33;
            this.labelNOInfo.Text = "Nitrogen Oxide (NO):";
            // 
            // labelNO
            // 
            this.labelNO.AutoSize = true;
            this.labelNO.BackColor = System.Drawing.Color.Transparent;
            this.labelNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNO.ForeColor = System.Drawing.Color.Black;
            this.labelNO.Location = new System.Drawing.Point(421, 784);
            this.labelNO.Name = "labelNO";
            this.labelNO.Size = new System.Drawing.Size(132, 32);
            this.labelNO.TabIndex = 34;
            this.labelNO.Text = "Unknown";
            // 
            // labelNO2Info
            // 
            this.labelNO2Info.AutoSize = true;
            this.labelNO2Info.BackColor = System.Drawing.Color.Transparent;
            this.labelNO2Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNO2Info.ForeColor = System.Drawing.Color.Black;
            this.labelNO2Info.Location = new System.Drawing.Point(72, 877);
            this.labelNO2Info.Name = "labelNO2Info";
            this.labelNO2Info.Size = new System.Drawing.Size(316, 32);
            this.labelNO2Info.TabIndex = 35;
            this.labelNO2Info.Text = "Nitrogen Dioxide (NO2):";
            // 
            // labelNO2
            // 
            this.labelNO2.AutoSize = true;
            this.labelNO2.BackColor = System.Drawing.Color.Transparent;
            this.labelNO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNO2.ForeColor = System.Drawing.Color.Black;
            this.labelNO2.Location = new System.Drawing.Point(421, 877);
            this.labelNO2.Name = "labelNO2";
            this.labelNO2.Size = new System.Drawing.Size(132, 32);
            this.labelNO2.TabIndex = 36;
            this.labelNO2.Text = "Unknown";
            // 
            // labelO3Info
            // 
            this.labelO3Info.AutoSize = true;
            this.labelO3Info.BackColor = System.Drawing.Color.Transparent;
            this.labelO3Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO3Info.ForeColor = System.Drawing.Color.Black;
            this.labelO3Info.Location = new System.Drawing.Point(658, 698);
            this.labelO3Info.Name = "labelO3Info";
            this.labelO3Info.Size = new System.Drawing.Size(169, 32);
            this.labelO3Info.TabIndex = 37;
            this.labelO3Info.Text = "Ozone (O3):";
            // 
            // labelO3
            // 
            this.labelO3.AutoSize = true;
            this.labelO3.BackColor = System.Drawing.Color.Transparent;
            this.labelO3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO3.ForeColor = System.Drawing.Color.Black;
            this.labelO3.Location = new System.Drawing.Point(1018, 698);
            this.labelO3.Name = "labelO3";
            this.labelO3.Size = new System.Drawing.Size(132, 32);
            this.labelO3.TabIndex = 38;
            this.labelO3.Text = "Unknown";
            // 
            // labelSO2Info
            // 
            this.labelSO2Info.AutoSize = true;
            this.labelSO2Info.BackColor = System.Drawing.Color.Transparent;
            this.labelSO2Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSO2Info.ForeColor = System.Drawing.Color.Black;
            this.labelSO2Info.Location = new System.Drawing.Point(663, 784);
            this.labelSO2Info.Name = "labelSO2Info";
            this.labelSO2Info.Size = new System.Drawing.Size(306, 32);
            this.labelSO2Info.TabIndex = 39;
            this.labelSO2Info.Text = "Sulphur Dioxide (SO2):";
            // 
            // labelSO2
            // 
            this.labelSO2.AutoSize = true;
            this.labelSO2.BackColor = System.Drawing.Color.Transparent;
            this.labelSO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSO2.ForeColor = System.Drawing.Color.Black;
            this.labelSO2.Location = new System.Drawing.Point(1018, 784);
            this.labelSO2.Name = "labelSO2";
            this.labelSO2.Size = new System.Drawing.Size(132, 32);
            this.labelSO2.TabIndex = 40;
            this.labelSO2.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(421, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "All measured in (µg/m³)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 1001);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSO2);
            this.Controls.Add(this.labelSO2Info);
            this.Controls.Add(this.labelO3);
            this.Controls.Add(this.labelO3Info);
            this.Controls.Add(this.labelNO2);
            this.Controls.Add(this.labelNO2Info);
            this.Controls.Add(this.labelNO);
            this.Controls.Add(this.labelNOInfo);
            this.Controls.Add(this.labelCO);
            this.Controls.Add(this.labelCOInfo);
            this.Controls.Add(this.labelAirPollution);
            this.Controls.Add(this.labelAirPollutionInfo);
            this.Controls.Add(this.labelLocationName);
            this.Controls.Add(this.labelCurrentWeather);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelFeelsLikeInfo);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelTemperatureInfo);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelHumidityInfo);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelPressureInfo);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelWindSpeedInfo);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunsetInfo);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelSunriseInfo);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.labelLocation);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1207, 1006);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.Text = "SunFinder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSunriseInfo;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunsetInfo;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelWindSpeedInfo;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelPressureInfo;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.Label labelHumidityInfo;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelTemperatureInfo;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelFeelsLikeInfo;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelUnit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelCurrentWeather;
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.Label labelAirPollutionInfo;
        private System.Windows.Forms.Label labelAirPollution;
        private System.Windows.Forms.Label labelCOInfo;
        private System.Windows.Forms.Label labelCO;
        private System.Windows.Forms.Label labelNOInfo;
        private System.Windows.Forms.Label labelNO;
        private System.Windows.Forms.Label labelNO2Info;
        private System.Windows.Forms.Label labelNO2;
        private System.Windows.Forms.Label labelO3Info;
        private System.Windows.Forms.Label labelO3;
        private System.Windows.Forms.Label labelSO2Info;
        private System.Windows.Forms.Label labelSO2;
        private System.Windows.Forms.Label label4;
    }
}


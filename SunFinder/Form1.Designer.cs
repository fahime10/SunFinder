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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.labelCondition = new System.Windows.Forms.Label();
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
            this.labelLocationName = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.labelUnit1 = new System.Windows.Forms.Label();
            this.labelUnit2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.CadetBlue;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(20, 33);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(236, 32);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location (by city):";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(515, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.BackColor = System.Drawing.Color.CadetBlue;
            this.txtBoxCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(274, 34);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(215, 39);
            this.txtBoxCity.TabIndex = 1;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.CadetBlue;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(72, 235);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(136, 32);
            this.labelCondition.TabIndex = 3;
            this.labelCondition.Text = "Condition";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(72, 301);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(102, 32);
            this.labelDetails.TabIndex = 4;
            this.labelDetails.Text = "Details";
            // 
            // labelSunriseInfo
            // 
            this.labelSunriseInfo.AutoSize = true;
            this.labelSunriseInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelSunriseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseInfo.ForeColor = System.Drawing.Color.White;
            this.labelSunriseInfo.Location = new System.Drawing.Point(658, 235);
            this.labelSunriseInfo.Name = "labelSunriseInfo";
            this.labelSunriseInfo.Size = new System.Drawing.Size(111, 32);
            this.labelSunriseInfo.TabIndex = 5;
            this.labelSunriseInfo.Text = "Sunrise";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.CadetBlue;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.ForeColor = System.Drawing.Color.White;
            this.labelSunrise.Location = new System.Drawing.Point(837, 235);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(61, 32);
            this.labelSunrise.TabIndex = 6;
            this.labelSunrise.Text = "N/A";
            // 
            // labelSunsetInfo
            // 
            this.labelSunsetInfo.AutoSize = true;
            this.labelSunsetInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelSunsetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetInfo.ForeColor = System.Drawing.Color.White;
            this.labelSunsetInfo.Location = new System.Drawing.Point(658, 301);
            this.labelSunsetInfo.Name = "labelSunsetInfo";
            this.labelSunsetInfo.Size = new System.Drawing.Size(103, 32);
            this.labelSunsetInfo.TabIndex = 7;
            this.labelSunsetInfo.Text = "Sunset";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.CadetBlue;
            this.labelSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.Color.White;
            this.labelSunset.Location = new System.Drawing.Point(837, 301);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(61, 32);
            this.labelSunset.TabIndex = 8;
            this.labelSunset.Text = "N/A";
            // 
            // labelWindSpeedInfo
            // 
            this.labelWindSpeedInfo.AutoSize = true;
            this.labelWindSpeedInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelWindSpeedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedInfo.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeedInfo.Location = new System.Drawing.Point(657, 373);
            this.labelWindSpeedInfo.Name = "labelWindSpeedInfo";
            this.labelWindSpeedInfo.Size = new System.Drawing.Size(170, 32);
            this.labelWindSpeedInfo.TabIndex = 9;
            this.labelWindSpeedInfo.Text = "WindSpeed:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.CadetBlue;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeed.Location = new System.Drawing.Point(837, 373);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(61, 32);
            this.labelWindSpeed.TabIndex = 10;
            this.labelWindSpeed.Text = "N/A";
            // 
            // labelPressureInfo
            // 
            this.labelPressureInfo.AutoSize = true;
            this.labelPressureInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelPressureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureInfo.ForeColor = System.Drawing.Color.White;
            this.labelPressureInfo.Location = new System.Drawing.Point(657, 444);
            this.labelPressureInfo.Name = "labelPressureInfo";
            this.labelPressureInfo.Size = new System.Drawing.Size(135, 32);
            this.labelPressureInfo.TabIndex = 11;
            this.labelPressureInfo.Text = "Pressure:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.CadetBlue;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(837, 444);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(61, 32);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "N/A";
            // 
            // pictureImage
            // 
            this.pictureImage.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureImage.Location = new System.Drawing.Point(78, 109);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(178, 105);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImage.TabIndex = 13;
            this.pictureImage.TabStop = false;
            // 
            // labelHumidityInfo
            // 
            this.labelHumidityInfo.AutoSize = true;
            this.labelHumidityInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelHumidityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityInfo.ForeColor = System.Drawing.Color.White;
            this.labelHumidityInfo.Location = new System.Drawing.Point(72, 373);
            this.labelHumidityInfo.Name = "labelHumidityInfo";
            this.labelHumidityInfo.Size = new System.Drawing.Size(140, 32);
            this.labelHumidityInfo.TabIndex = 14;
            this.labelHumidityInfo.Text = "Humidity: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.CadetBlue;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.ForeColor = System.Drawing.Color.White;
            this.labelHumidity.Location = new System.Drawing.Point(307, 373);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(132, 32);
            this.labelHumidity.TabIndex = 15;
            this.labelHumidity.Text = "Unknown";
            // 
            // labelTemperatureInfo
            // 
            this.labelTemperatureInfo.AutoSize = true;
            this.labelTemperatureInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelTemperatureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureInfo.ForeColor = System.Drawing.Color.White;
            this.labelTemperatureInfo.Location = new System.Drawing.Point(72, 444);
            this.labelTemperatureInfo.Name = "labelTemperatureInfo";
            this.labelTemperatureInfo.Size = new System.Drawing.Size(184, 32);
            this.labelTemperatureInfo.TabIndex = 16;
            this.labelTemperatureInfo.Text = "Temperature:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.CadetBlue;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Location = new System.Drawing.Point(307, 444);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(132, 32);
            this.labelTemperature.TabIndex = 17;
            this.labelTemperature.Text = "Unknown";
            // 
            // labelFeelsLikeInfo
            // 
            this.labelFeelsLikeInfo.AutoSize = true;
            this.labelFeelsLikeInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelFeelsLikeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLikeInfo.ForeColor = System.Drawing.Color.White;
            this.labelFeelsLikeInfo.Location = new System.Drawing.Point(658, 170);
            this.labelFeelsLikeInfo.Name = "labelFeelsLikeInfo";
            this.labelFeelsLikeInfo.Size = new System.Drawing.Size(143, 32);
            this.labelFeelsLikeInfo.TabIndex = 18;
            this.labelFeelsLikeInfo.Text = "Feels like:";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.CadetBlue;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.ForeColor = System.Drawing.Color.White;
            this.labelFeelsLike.Location = new System.Drawing.Point(837, 170);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(132, 32);
            this.labelFeelsLike.TabIndex = 20;
            this.labelFeelsLike.Text = "Unknown";
            // 
            // labelLocationName
            // 
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.BackColor = System.Drawing.Color.CadetBlue;
            this.labelLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationName.ForeColor = System.Drawing.Color.White;
            this.labelLocationName.Location = new System.Drawing.Point(316, 143);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(173, 46);
            this.labelLocationName.TabIndex = 21;
            this.labelLocationName.Text = "Location";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnConverter.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelUnit1.BackColor = System.Drawing.Color.CadetBlue;
            this.labelUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit1.ForeColor = System.Drawing.Color.White;
            this.labelUnit1.Location = new System.Drawing.Point(434, 444);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(45, 32);
            this.labelUnit1.TabIndex = 25;
            this.labelUnit1.Text = "°C";
            // 
            // labelUnit2
            // 
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.BackColor = System.Drawing.Color.CadetBlue;
            this.labelUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit2.ForeColor = System.Drawing.Color.White;
            this.labelUnit2.Location = new System.Drawing.Point(966, 170);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(45, 32);
            this.labelUnit2.TabIndex = 26;
            this.labelUnit2.Text = "°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 612);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.labelLocationName);
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
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.labelLocation);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "SunFinder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label labelCondition;
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
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelUnit2;
    }
}


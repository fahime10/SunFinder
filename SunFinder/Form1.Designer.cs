﻿namespace SunFinder
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
            this.labelCity = new System.Windows.Forms.Label();
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
            this.labelCityName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(61, 34);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(71, 32);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(384, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(148, 34);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(215, 39);
            this.txtBoxCity.TabIndex = 1;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
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
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
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
            this.labelSunriseInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelSunriseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseInfo.ForeColor = System.Drawing.Color.White;
            this.labelSunriseInfo.Location = new System.Drawing.Point(572, 235);
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
            this.labelSunrise.ForeColor = System.Drawing.Color.White;
            this.labelSunrise.Location = new System.Drawing.Point(766, 235);
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
            this.labelSunsetInfo.ForeColor = System.Drawing.Color.White;
            this.labelSunsetInfo.Location = new System.Drawing.Point(572, 301);
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
            this.labelSunset.ForeColor = System.Drawing.Color.White;
            this.labelSunset.Location = new System.Drawing.Point(766, 301);
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
            this.labelWindSpeedInfo.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeedInfo.Location = new System.Drawing.Point(572, 373);
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
            this.labelWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeed.Location = new System.Drawing.Point(766, 373);
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
            this.labelPressureInfo.ForeColor = System.Drawing.Color.White;
            this.labelPressureInfo.Location = new System.Drawing.Point(572, 444);
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
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(766, 444);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(61, 32);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "N/A";
            // 
            // pictureImage
            // 
            this.pictureImage.BackColor = System.Drawing.Color.Transparent;
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
            this.labelHumidityInfo.BackColor = System.Drawing.Color.Transparent;
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
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
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
            this.labelTemperatureInfo.BackColor = System.Drawing.Color.Transparent;
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
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
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
            this.labelFeelsLikeInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLikeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLikeInfo.ForeColor = System.Drawing.Color.White;
            this.labelFeelsLikeInfo.Location = new System.Drawing.Point(572, 170);
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
            this.labelFeelsLike.ForeColor = System.Drawing.Color.White;
            this.labelFeelsLike.Location = new System.Drawing.Point(772, 170);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(132, 32);
            this.labelFeelsLike.TabIndex = 20;
            this.labelFeelsLike.Text = "Unknown";
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.BackColor = System.Drawing.Color.Transparent;
            this.labelCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityName.ForeColor = System.Drawing.Color.White;
            this.labelCityName.Location = new System.Drawing.Point(690, 52);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(89, 46);
            this.labelCityName.TabIndex = 21;
            this.labelCityName.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 557);
            this.Controls.Add(this.labelCityName);
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
            this.Controls.Add(this.labelCity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCity;
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
        private System.Windows.Forms.Label labelCityName;
    }
}


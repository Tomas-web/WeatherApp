
namespace Weather
{
    partial class WeatherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.longtitudeTextBox = new System.Windows.Forms.TextBox();
            this.weatherDataBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePeriodLabel = new System.Windows.Forms.Label();
            this.averageTemperatureLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cloudyTemperatureLabel = new System.Windows.Forms.Label();
            this.nonCloudyTemperatureLabel = new System.Windows.Forms.Label();
            this.temperatureDiffLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currTemperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weather";
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(12, 57);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(50, 20);
            this.latitudeTextBox.TabIndex = 1;
            this.latitudeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Longtitude";
            // 
            // longtitudeTextBox
            // 
            this.longtitudeTextBox.Location = new System.Drawing.Point(12, 83);
            this.longtitudeTextBox.Name = "longtitudeTextBox";
            this.longtitudeTextBox.Size = new System.Drawing.Size(50, 20);
            this.longtitudeTextBox.TabIndex = 4;
            // 
            // weatherDataBtn
            // 
            this.weatherDataBtn.Location = new System.Drawing.Point(12, 122);
            this.weatherDataBtn.Name = "weatherDataBtn";
            this.weatherDataBtn.Size = new System.Drawing.Size(75, 23);
            this.weatherDataBtn.TabIndex = 5;
            this.weatherDataBtn.Text = "Get data";
            this.weatherDataBtn.UseVisualStyleBackColor = true;
            this.weatherDataBtn.Click += new System.EventHandler(this.weatherDataBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Period:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 8;
            // 
            // datePeriodLabel
            // 
            this.datePeriodLabel.AutoSize = true;
            this.datePeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePeriodLabel.Location = new System.Drawing.Point(329, 13);
            this.datePeriodLabel.Name = "datePeriodLabel";
            this.datePeriodLabel.Size = new System.Drawing.Size(103, 20);
            this.datePeriodLabel.TabIndex = 9;
            this.datePeriodLabel.Text = "Data period";
            // 
            // averageTemperatureLabel
            // 
            this.averageTemperatureLabel.AutoSize = true;
            this.averageTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTemperatureLabel.Location = new System.Drawing.Point(401, 82);
            this.averageTemperatureLabel.Name = "averageTemperatureLabel";
            this.averageTemperatureLabel.Size = new System.Drawing.Size(31, 16);
            this.averageTemperatureLabel.TabIndex = 10;
            this.averageTemperatureLabel.Text = "0 °C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Average temperature when cloudy:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(257, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Average temperature when not cloudy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(312, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Average cloudy/non cloudy temperature difference:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(257, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Highest wind speed:";
            // 
            // cloudyTemperatureLabel
            // 
            this.cloudyTemperatureLabel.AutoSize = true;
            this.cloudyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudyTemperatureLabel.Location = new System.Drawing.Point(478, 112);
            this.cloudyTemperatureLabel.Name = "cloudyTemperatureLabel";
            this.cloudyTemperatureLabel.Size = new System.Drawing.Size(31, 16);
            this.cloudyTemperatureLabel.TabIndex = 17;
            this.cloudyTemperatureLabel.Text = "0 °C";
            // 
            // nonCloudyTemperatureLabel
            // 
            this.nonCloudyTemperatureLabel.AutoSize = true;
            this.nonCloudyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonCloudyTemperatureLabel.Location = new System.Drawing.Point(500, 140);
            this.nonCloudyTemperatureLabel.Name = "nonCloudyTemperatureLabel";
            this.nonCloudyTemperatureLabel.Size = new System.Drawing.Size(31, 16);
            this.nonCloudyTemperatureLabel.TabIndex = 18;
            this.nonCloudyTemperatureLabel.Text = "0 °C";
            // 
            // temperatureDiffLabel
            // 
            this.temperatureDiffLabel.AutoSize = true;
            this.temperatureDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureDiffLabel.Location = new System.Drawing.Point(576, 171);
            this.temperatureDiffLabel.Name = "temperatureDiffLabel";
            this.temperatureDiffLabel.Size = new System.Drawing.Size(31, 16);
            this.temperatureDiffLabel.TabIndex = 19;
            this.temperatureDiffLabel.Text = "0 °C";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(392, 201);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(40, 16);
            this.windSpeedLabel.TabIndex = 20;
            this.windSpeedLabel.Text = "0 m/s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Current temperature:";
            // 
            // currTemperatureLabel
            // 
            this.currTemperatureLabel.AutoSize = true;
            this.currTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTemperatureLabel.Location = new System.Drawing.Point(392, 58);
            this.currTemperatureLabel.Name = "currTemperatureLabel";
            this.currTemperatureLabel.Size = new System.Drawing.Size(31, 16);
            this.currTemperatureLabel.TabIndex = 22;
            this.currTemperatureLabel.Text = "0 °C";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currTemperatureLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.temperatureDiffLabel);
            this.Controls.Add(this.nonCloudyTemperatureLabel);
            this.Controls.Add(this.cloudyTemperatureLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.averageTemperatureLabel);
            this.Controls.Add(this.datePeriodLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weatherDataBtn);
            this.Controls.Add(this.longtitudeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox longtitudeTextBox;
        private System.Windows.Forms.Button weatherDataBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label datePeriodLabel;
        private System.Windows.Forms.Label averageTemperatureLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cloudyTemperatureLabel;
        private System.Windows.Forms.Label nonCloudyTemperatureLabel;
        private System.Windows.Forms.Label temperatureDiffLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currTemperatureLabel;
    }
}


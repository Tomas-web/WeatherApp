using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLibrary;

namespace Weather
{
    public partial class WeatherForm : Form
    {
        private WeatherDataProvider provider;
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            latitudeTextBox.Text = "54.69";
            longtitudeTextBox.Text = "25.28";
            provider = new WeatherDataProvider();
        }

        private void weatherDataBtn_Click(object sender, EventArgs e)
        {
            double latitude;
            double longtitude;
            if (!double.TryParse(latitudeTextBox.Text, out latitude))
            {
                return;
            }

            if (!double.TryParse(longtitudeTextBox.Text, out longtitude))
            {
                return;
            }

            var repository = new WeatherDataRepository(provider);
            var temperatureData = repository.getTemperatureData(latitude, longtitude);
            var highestWindSpeed = repository.getHighestWindSpeed(latitude, longtitude);

            currTemperatureLabel.Text = $"{temperatureData.CurrTemperature} °C";
            averageTemperatureLabel.Text = $"{temperatureData.AvgTemperature} °C";
            cloudyTemperatureLabel.Text = $"{temperatureData.AvgTemperatureCloudy} °C";
            nonCloudyTemperatureLabel.Text = $"{temperatureData.AvgTemperatureNonCloudy} °C";
            temperatureDiffLabel.Text = $"{temperatureData.CloudyTemperatureDiff} °C";
            datePeriodLabel.Text = $"{temperatureData.StartDate} - {temperatureData.EndDate}";
            windSpeedLabel.Text = $"{highestWindSpeed} m/s";
        }
    }
}

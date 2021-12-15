using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary.Models
{
    public class TemperatureData
    {
        private double currTemperature;
        private double currWindspeed;
        private double avgTemperature;
        private double avgTemperatureCloudy;
        private double avgTemperatureNonCloudy;
        private double cloudyTemperatureDiff;
        private DateTime startDate;
        private DateTime endDate;

        public double CurrTemperature { get => currTemperature; set => currTemperature = value; }
        public double AvgTemperature { get => avgTemperature; set => avgTemperature = value; }
        public double AvgTemperatureCloudy { get => avgTemperatureCloudy; set => avgTemperatureCloudy = value; }
        public double AvgTemperatureNonCloudy { get => avgTemperatureNonCloudy; set => avgTemperatureNonCloudy = value; }
        public double CloudyTemperatureDiff { get => cloudyTemperatureDiff; set => cloudyTemperatureDiff = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public double CurrWindspeed { get => currWindspeed; set => currWindspeed = value; }
    }
}

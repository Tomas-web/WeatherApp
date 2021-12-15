using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherLibrary.Models;

namespace WeatherLibrary
{
    public class WeatherDataRepository
    {
        private readonly IWeatherDataProvider m_provider;

        public WeatherDataRepository(IWeatherDataProvider provider)
        {
            m_provider = provider;
        }

        public double getHighestWindSpeed(double latitude, double longtitude)
        {
            var windData = m_provider.getWindData(latitude, longtitude);

            var speeds = windData.hourly.windspeed_10m;
            double max = 0;

            foreach(var speed in speeds)
            {
                if (speed > max)
                {
                    max = speed;
                }
            }

            return max;
        }

        public TemperatureData getTemperatureData(double latitude, double longtitude)
        {
            var temperatureData = m_provider.getTemperatures(latitude, longtitude);
            var cloudCoverData = m_provider.getCloudCoverData(latitude, longtitude);

            var result = new TemperatureData();

            result.StartDate = temperatureData.hourly.time.First();
            result.EndDate = temperatureData.hourly.time.Last();

            var cloudyTemparatures = new List<double>();
            var nonCloudyTemparatures = new List<double>();

            var cloudValues = cloudCoverData.hourly.cloudcover;
            var temperatureValues = temperatureData.hourly.temperature_2m;

            for (var i = 0; i < cloudValues.Count(); i++)
            {
                if (cloudValues.ElementAt(i) <= 30)
                {
                    nonCloudyTemparatures.Add(temperatureValues.ElementAt(i));
                }
                else if (cloudValues.ElementAt(i) >= 80)
                {
                    cloudyTemparatures.Add(temperatureValues.ElementAt(i));
                }
            }

            var avgCloudyTemperature = round(cloudyTemparatures.Count() > 0 ? cloudyTemparatures.Average() : 0);
            var avgNonCloudyTemperature = round(nonCloudyTemparatures.Count() > 0 ? nonCloudyTemparatures.Average() : 0);

            result.AvgTemperature = round(temperatureValues.Average());
            result.AvgTemperatureCloudy = avgCloudyTemperature;
            result.AvgTemperatureNonCloudy = avgNonCloudyTemperature;
            result.CloudyTemperatureDiff = round(avgCloudyTemperature - avgNonCloudyTemperature);
            result.CurrTemperature = temperatureData.current_weather.temperature;
            result.CurrWindspeed = temperatureData.current_weather.windspeed;

            return result;
        }

        private double round(double value)
        {
            return Math.Round(value * 100) / 100;
        }
    }
}

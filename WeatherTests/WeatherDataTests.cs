using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WeatherLibrary;
using WeatherLibrary.Payloads;

namespace WeatherTests
{
    [TestClass]
    public class WeatherDataTests
    {
        [TestMethod]
        public void TestHighestWindSpeed()
        {
            var values = new List<double> { 2, 4, 9, 5 };
            var data = new WeatherDataWindPayload { 
                hourly = new HourlyWind { 
                    windspeed_10m = values
                }
            };

            var provider = new FakeWeatherDataProvider(data);
            var repository = new WeatherDataRepository(provider);

            Assert.AreEqual(values[2], repository.getHighestWindSpeed(0, 0));
        }

        [TestMethod]
        public void TestTemperatureData()
        {
            var temperatureValues = new List<double> { 2, 4, 6, 8 };
            var times = new List<DateTime> { DateTime.Now, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3) };
            var temperatureData = new WeatherDataTemperaturePayload
            {
                current_weather = new CurrentWeather { temperature = 1, windspeed = 4 },
                hourly = new HourlyTemperature { 
                    temperature_2m = temperatureValues,
                    time = times
                }
            };

            var cloudValues = new List<double> { 30, 10, 80, 90 };
            var cloudData = new WeatherDataCloudCoverPayload
            {
                hourly = new HourlyCloudCover
                {
                    cloudcover = cloudValues
                }
            };

            var provider = new FakeWeatherDataProvider(cloudData, temperatureData);
            var repository = new WeatherDataRepository(provider);

            var calculatedData = repository.getTemperatureData(0, 0);

            Assert.AreEqual(times[0], calculatedData.StartDate);
            Assert.AreEqual(times[3], calculatedData.EndDate);
            Assert.AreEqual(3, calculatedData.AvgTemperatureNonCloudy);
            Assert.AreEqual(7, calculatedData.AvgTemperatureCloudy);
            Assert.AreEqual(4, calculatedData.CloudyTemperatureDiff);
            Assert.AreEqual(1, calculatedData.CurrTemperature);
            Assert.AreEqual(4, calculatedData.CurrWindspeed);
            Assert.AreEqual(5, calculatedData.AvgTemperature);
        }
    }
}

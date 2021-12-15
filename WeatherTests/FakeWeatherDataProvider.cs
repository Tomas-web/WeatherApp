using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherLibrary;
using WeatherLibrary.Payloads;

namespace WeatherTests
{
    public class FakeWeatherDataProvider : IWeatherDataProvider
    {
        WeatherDataCloudCoverPayload m_cloudPayload;
        WeatherDataTemperaturePayload m_temperaturePayload;
        WeatherDataWindPayload m_windPayload;

        public FakeWeatherDataProvider(WeatherDataWindPayload windPayload)
        {
            m_windPayload = windPayload;
        }

        public FakeWeatherDataProvider(
            WeatherDataCloudCoverPayload cloudPayload, 
            WeatherDataTemperaturePayload temperaturePayload)
        {
            m_cloudPayload = cloudPayload;
            m_temperaturePayload = temperaturePayload;
        }

        public WeatherDataCloudCoverPayload getCloudCoverData(double latitude, double longtitude)
        {
            return m_cloudPayload;
        }

        public WeatherDataTemperaturePayload getTemperatures(double latitude, double longtitude)
        {
            return m_temperaturePayload;
        }

        public WeatherDataWindPayload getWindData(double latitude, double longtitude)
        {
            return m_windPayload;
        }
    }
}

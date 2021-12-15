using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherLibrary.Models;
using WeatherLibrary.Payloads;

namespace WeatherLibrary
{
    public interface IWeatherDataProvider
    {
        WeatherDataTemperaturePayload getTemperatures(double latitude, double longtitude);
        WeatherDataCloudCoverPayload getCloudCoverData(double latitude, double longtitude);
        WeatherDataWindPayload getWindData(double latitude, double longtitude);
    }
}

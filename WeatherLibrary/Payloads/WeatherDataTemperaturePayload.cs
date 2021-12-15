using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary.Payloads
{
    public class WeatherDataTemperaturePayload : WeatherData
    {
        public HourlyTemperature hourly;
    }
}

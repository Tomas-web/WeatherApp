using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary.Payloads
{
    public class WeatherDataCloudCoverPayload : WeatherData
    {
        public HourlyCloudCover hourly;
    }
}

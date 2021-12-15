using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary.Payloads
{
    public class HourlyTemperature
    {
        public IEnumerable<DateTime> time;
        public IEnumerable<double> temperature_2m;
    }
}

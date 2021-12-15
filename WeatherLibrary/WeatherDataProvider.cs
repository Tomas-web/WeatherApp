using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherLibrary.Models;
using WeatherLibrary.Payloads;

namespace WeatherLibrary
{
    public class WeatherDataProvider : IWeatherDataProvider
    {
        private RestClient m_client;

        public WeatherDataProvider()
        {
            m_client = new RestClient("https://api.open-meteo.com/v1/forecast");
            m_client.Timeout = -1;
        }

        public WeatherDataWindPayload getWindData(double latitude, double longtitude)
        {
            var queryParams = $"?latitude={latitude}&longitude={longtitude}&hourly=windspeed_10m&current_weather=true&windspeed_unit=ms";
            var windRequest = new RestRequest(queryParams, Method.GET);
            var windResponse = m_client.Get(windRequest);
            return JsonConvert.DeserializeObject<WeatherDataWindPayload>(windResponse.Content);
        }

        public WeatherDataTemperaturePayload getTemperatures(double latitude, double longtitude)
        {
            var queryParams = $"?current_weather=true&windspeed_unit=ms&latitude={latitude}&longitude={longtitude}&hourly=temperature_2m";
            var temperatureRequest = new RestRequest(queryParams, Method.GET);
            var temperatureResponse = m_client.Get(temperatureRequest);
            return JsonConvert.DeserializeObject<WeatherDataTemperaturePayload>(temperatureResponse.Content);
        }

        public WeatherDataCloudCoverPayload getCloudCoverData(double latitude, double longtitude)
        {
            var queryParams = $"?current_weather=true&windspeed_unit=ms&latitude={latitude}&longitude={longtitude}&hourly=cloudcover";
            var cloudCoverRequest = new RestRequest(queryParams, Method.GET);
            var cloudCoverResponse = m_client.Get(cloudCoverRequest);
            return JsonConvert.DeserializeObject<WeatherDataCloudCoverPayload>(cloudCoverResponse.Content);
        }
    }
}

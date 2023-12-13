using System;
using System.Diagnostics;
using System.Net;
using CuteIoT.Epaper;
using CuteIoT.Widgets;
using nanoFramework.Json;

#nullable enable

namespace CuteIoT.Services
{
    internal class WeatherService
    {
        private readonly Configuration _configuration;
        private readonly CurrentWeatherWidget _currentWeatherWidget;

        public WeatherService(Configuration configuration, CurrentWeatherWidget currentWeatherWidget)
        {
            _configuration = configuration;
            _currentWeatherWidget = currentWeatherWidget;
        }

        public void Refresh(Display display)
        {
            var response = Fetch();
            if (response == null)
            {
                response = Fetch();
            }
            if (response != null)
            {
                _currentWeatherWidget.Draw(display, response);
            }
        }

        private WeatherResponse? Fetch()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(_configuration.CurrentWeaterApiUrl);
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 3000;
            httpWebRequest.SslProtocols = System.Net.Security.SslProtocols.Tls12;

            try
            {
                Debug.WriteLine("Fetching weater api");
                using var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using var responseStream = httpWebResponse.GetResponseStream();
                return (WeatherResponse)JsonConvert.DeserializeObject(responseStream, typeof(WeatherResponse));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Unable to fetch api:" + e.Message);
                return null;
            }

        }
    }
}

using System;
using System.Diagnostics;
using System.Net;
using CuteIoT.Epaper;
using CuteIoT.Widgets;
using nanoFramework.Json;
using nanoFramework.Networking;

#nullable enable

namespace CuteIoT.Services
{
    internal class WeatherService
    {
        private readonly ConfigurationOptions _configuration;
        private readonly CurrentWeatherWidget _currentWeatherWidget;

        public WeatherService(ConfigurationOptions configuration, CurrentWeatherWidget currentWeatherWidget)
        {
            _configuration = configuration;
            _currentWeatherWidget = currentWeatherWidget;
        }

        public void Refresh(Display display)
        {
            while (WifiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady)
            {
                Debug.Write("Wifi reconnecting:");
                var success = WifiNetworkHelper.Reconnect();
                Debug.Write(success ? "ok" : "fail");
            }


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
                Debug.Write("Fetching weater api:");
                using var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Debug.WriteLine(httpWebResponse.StatusCode.ToString());
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

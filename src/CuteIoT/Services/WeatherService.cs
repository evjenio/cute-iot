using System;
using System.Diagnostics;
using System.Net;
using nanoFramework.Json;
using nanoFramework.Networking;

#nullable enable

namespace CuteIoT.Services
{
    internal class WeatherService
    {
        private readonly ConfigurationOptions _configuration;

        public WeatherService(ConfigurationOptions configuration)
        {
            _configuration = configuration;
        }

        public WeatherResponse? Get()
        {
            int count = 0;
            while (WifiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady && count++ < 4)
            {
                Debug.Write("Wifi reconnecting:");
                var success = WifiNetworkHelper.Reconnect();
                Debug.Write(success ? "ok" : "fail");
            }

            if (WifiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady)
            {
                return null;
            }

            var response = Fetch();
            if (response == null)
            {
                response = Fetch();
            }

            return response;
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

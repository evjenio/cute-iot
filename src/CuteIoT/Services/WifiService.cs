using System;
using System.Threading;
using CuteIoT.Epaper;
using nanoFramework.Networking;
using CuteIoT.Widgets;

namespace CuteIoT.Services
{
    internal class WifiService
    {
        private readonly ConfigurationOptions _configuration;
        private readonly WifiWidget _wifiWidget;

        public WifiService(ConfigurationOptions configuration, WifiWidget wifiWidget)
        {
            _configuration = configuration;
            _wifiWidget = wifiWidget;
        }

        public void Connect(Display display)
        {
            //Draw initial state
            _wifiWidget.Draw(display);

            bool connected;
            do
            {
                connected = WifiNetworkHelper.ConnectDhcp(_configuration.Ssid, _configuration.Password);

                _wifiWidget.Draw(display);
                if (!connected)
                {
                    Thread.Sleep(TimeSpan.FromMinutes(1));
                }
            } while (!connected);
        }
    }
}

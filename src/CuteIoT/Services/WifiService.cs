using System.Diagnostics;
using nanoFramework.Networking;

namespace CuteIoT.Services
{
    internal class WifiService
    {
        private readonly ConfigurationOptions _configuration;

        public WifiService(ConfigurationOptions configuration)
        {
            _configuration = configuration;
        }

        public bool Connect()
        {

            bool connected =false;
            int count = 0;
            while (WifiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady && count++ < 4)
            {
                Debug.WriteLine("Wifi: connecting");
                connected = WifiNetworkHelper.ConnectDhcp(_configuration.Ssid, _configuration.Password, requiresDateTime: true);
                Debug.WriteLine("Wifi: " + WifiNetworkHelper.Status.ToString());
            }

            return connected;
        }
    }
}

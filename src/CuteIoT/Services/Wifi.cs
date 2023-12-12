using System;
using System.Threading;
using System.IO;
using CuteIoT.Epaper;
using nanoFramework.Networking;
using CuteIoT.Widgets;

namespace CuteIoT.Services
{
    internal class Wifi
    {
        const string Ssid = "Keenetic-7613";
        private readonly WifiWidget _wifiWidget;

        public Wifi(WifiWidget wifiWidget)
        {
            _wifiWidget = wifiWidget;
        }

        public void Connect(Display display)
        {
            string password;
            try
            {
                using var file = File.OpenText("I:\\wifi.txt");
                password = file.ReadToEnd();
            }
            catch (Exception e)
            {
                display.SetCursor(26, 0); //TODO: make widget
                display.Write(e.Message);
                display.UpdateWindow(0, 0, 250, 20);

                return;
            }

            // connecting
            bool connected;
            do
            {
                connected = WifiNetworkHelper.ConnectDhcp(Ssid, password);

                _wifiWidget.Draw(display);
                if (!connected)
                {
                    Thread.Sleep(TimeSpan.FromMinutes(1));
                }
            } while (!connected);
        }

    }
}

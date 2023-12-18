using System;
using System.Threading;
using CuteIoT.Epaper;
using CuteIoT.Widgets;
using CuteIoT.Services;
using nanoFramework.Hardware.Esp32;
using nanoFramework.Networking;
using System.Diagnostics;
using System.Device.Gpio;

#nullable enable

namespace CuteIoT
{
    public class Program
    {
        private static Display _display = null!;
        private static WeatherService _weatherService = null!;
        private static BatteryService _batteryService = null!;
        private static ConfigurationOptions _configuration = null!;

        private static readonly ConfigurationService _configurationService = new();

        private static readonly WifiWidget _wifiWidget = new();
        private static readonly NoBatteryWidget _noBatteryWidget = new();
        private static readonly TextClockWidget _textClockWidget = new();
        private static readonly CurrentWeatherWidget _currentWeatherWidget = new();
        private static readonly BatteryWidget _batteryWidget = new();

        public static void Main()
        {
            nanoFramework.Json.Configuration.Settings.CaseSensitive = false;
            try
            {
                Debug.WriteLine("Starting...");

                var wakeupCause = Sleep.GetWakeupCause();
                Debug.WriteLine($"Wakeup by {wakeupCause}");
                if (wakeupCause == Sleep.WakeupCause.Undefined)
                {
                    Debug.WriteLine("Waiting 20 sec for FW update...");
                    Thread.Sleep(TimeSpan.FromSeconds(20));
                }

                _batteryService = new();

                _display = new Display();
                _display.Init();
                _display.SetRotation(1);
                _display.FillScreen(Color.White);

                var batteryVoltage = _batteryService.ReadVoltage();
                if (batteryVoltage < 3.5)
                {
                    _noBatteryWidget.Draw(_display);
                    GoToDeepSleep(TimeSpan.FromMinutes(15));
                    return;
                }

                _configuration = _configurationService.Read();

                _weatherService = new WeatherService(_configuration);
                
                var date = DateTime.UtcNow;
                if (date.Minute % 20 == 0 || wakeupCause == Sleep.WakeupCause.Undefined || date.Year < 2023)
                {
                    var wifi = new WifiService(_configuration);
                    var connected = wifi.Connect();
                }

                DrawWidgets(batteryVoltage);
            }
            catch
            {
                // just to go to sleep
            }
            finally
            {
                GoToDeepSleep(TimeSpan.FromSeconds(45));
                Thread.Sleep(Timeout.Infinite);
            }
        }

        private static void DrawWidgets(double batteryVoltage)
        {
            var datetime = DateTime.UtcNow.AddSeconds(_configuration.Timezone);

            _batteryWidget.Draw(_display, batteryVoltage);
            _textClockWidget.Draw(_display, datetime);
            _wifiWidget.Draw(_display);

            if (WifiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady)
            {
                _display.UpdateWindow(0, 0, _display.Width, 20);
                Debug.WriteLine("Skiping weather update");
                return;
            }

            var response = _weatherService.Get();

            _currentWeatherWidget.Draw(_display, response);
            _display.UpdateWindow(0, 0, _display.Width, _display.Height);
        }

        private static void GoToDeepSleep(TimeSpan period)
        {
            Debug.WriteLine("Going to deep sleep");
            Sleep.EnableWakeupByTimer(period);
            // Enable low power consumption of mem
            var gpioController = new GpioController();
            var pin13 = gpioController.OpenPin(13, PinMode.Output);
            pin13.Write(PinValue.High);
            Sleep.StartDeepSleep();
        }
    }
}

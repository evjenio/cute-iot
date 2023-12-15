using System;
using System.Threading;
using CuteIoT.Epaper;
using CuteIoT.Widgets;
using CuteIoT.Services;
using nanoFramework.Hardware.Esp32;

#nullable enable

namespace CuteIoT
{
    public class Program
    {
        private static Display _display = null!;
        private static WeatherService _weather = null!;
        private static ConfigurationOptions _configuration = null!;

        private static readonly ConfigurationService _configurationService = new();
        private static readonly LoadingWidget _loadingWidget = new();
        private static readonly WifiWidget _wifiWidget = new();
        private static readonly TextClockWidget _textClockWidget = new();
        private static readonly CurrentWeatherWidget _currentWeatherWidget = new();
        private static readonly BatteryWidget _batteryWidget = new();

        public static void Main()
        {
            nanoFramework.Json.Configuration.Settings.CaseSensitive = false;

            _display = new Display();
            _display.Init();
            _display.SetRotation(1);

            _loadingWidget.Draw(_display);

            _configuration = _configurationService.Read();

            var wifi = new WifiService(_configuration, _wifiWidget);
            wifi.Connect(_display);
            _display.UpdateWindow(0, 0, _display.Width, _display.Height);

            _weather = new WeatherService(_configuration, _currentWeatherWidget);

            DrawClockAndToolbar(true);

            var timer1Minute = new Timer(DrawClockAndToolbar, null, TimeSpan.FromMinutes(1).Subtract(TimeSpan.FromSeconds(DateTime.UtcNow.Second)), TimeSpan.FromMinutes(1));
            var timer30Minute = new Timer(DrawWeather, null, TimeSpan.FromSeconds(1), TimeSpan.FromMinutes(15));

            Thread.Sleep(Timeout.Infinite);
        }

        private static void DrawClockAndToolbar(object? p)
        {
            var datetime = DateTime.UtcNow.AddSeconds(_configuration.Timezone);
            lock (_display)
            {
                _batteryWidget.Draw(_display);
                _textClockWidget.Draw(_display, datetime);
                _wifiWidget.Draw(_display);
            }
#if !DEBUG
            if (p is null)
            {
                Sleep.EnableWakeupByTimer(TimeSpan.FromSeconds(50));
                Sleep.StartLightSleep();
            }
#endif
        }

        private static void DrawWeather(object? p)
        {
            lock (_display)
            {
                _weather.Refresh(_display);
            }
        }
    }
}

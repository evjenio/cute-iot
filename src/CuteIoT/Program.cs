using System;
using System.Threading;
using CuteIoT.Epaper;
using CuteIoT.Resources;
using CuteIoT.Widgets;
using CuteIoT.Services;

#nullable enable

namespace CuteIoT
{
    public class Program
    {

        const int TimeZone = 3;

        private static Display _display = null!;

        private static readonly WifiWidget _wifiWidget = new();
        private static readonly ToolBarSeparator _toolBarSeparator = new();
        private static readonly TextClockWidget _textClockWidget = new();
        private static readonly ClockWidget _clockWidget = new();
        private static readonly CurrentWeatherWidget _currentWeatherWidget = new();

        public static void Main()
        {
            _display = new Display();
            _display.Init();
            // loading
            _display.SetRotation(1);
            _display.FillScreen(Color.White);
            _display.DrawBitmap(Bitmaps.CuteCat.Bitmap, 95, 40, Bitmaps.CuteCat.Width, Bitmaps.CuteCat.Heigth, Color.White);

            _display.SetFontSize(1);

            _display.UpdateWindow(0, 0, _display.Width, _display.Height);
            _display.FillScreen(Color.White);

            _toolBarSeparator.Draw(_display);
            _wifiWidget.Draw(_display);
            var wifi = new Wifi(_wifiWidget);
            wifi.Connect(_display);
            
            DrawClockAndToolbar(null);
            var timer1Minute = new Timer(DrawClockAndToolbar, null, TimeSpan.FromMinutes(1).Subtract(TimeSpan.FromSeconds(DateTime.UtcNow.Second)), TimeSpan.FromMinutes(1));
            var timer30Minute = new Timer(DrawWeather, null, TimeSpan.Zero, TimeSpan.FromMinutes(30));

            Thread.Sleep(Timeout.Infinite);
        }

        private static void DrawClockAndToolbar(object? p)
        {
            var datetime = DateTime.UtcNow.AddHours(TimeZone);
            lock (_display)
            {
                // _clockWidget.Draw(_display, datetime);
                _textClockWidget.Draw(_display, datetime);
                _wifiWidget.Draw(_display);
            }
        }

        private static void DrawWeather(object? p)
        {
            lock (_display)
            {
                _currentWeatherWidget.Draw(_display);
            }
        }
    }
}

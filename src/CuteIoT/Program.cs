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

            var timer1Minute = new Timer(RefreshScreen, null, TimeSpan.FromMinutes(1).Subtract(TimeSpan.FromSeconds(DateTime.UtcNow.Second)), TimeSpan.FromMinutes(1));

            Thread.Sleep(Timeout.Infinite);
        }

        private static void RefreshScreen(object p)
        {
            var datetime = DateTime.UtcNow.AddHours(TimeZone);
            _clockWidget.Draw(_display, datetime);
            _textClockWidget.Draw(_display, datetime);
            _wifiWidget.Draw(_display);
        }
    }
}

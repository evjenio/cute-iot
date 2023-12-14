using System;
using CuteIoT.Epaper;
using CuteIoT.Services;
using CuteIoT.Resources;

namespace CuteIoT.Widgets
{
    using Icon = Bitmaps.Weather;

    internal class CurrentWeatherWidget
    {
        public int X { get; set; } = 80;
        public int Y { get; set; } = 50;
        private const int H = 48 + 14;

        public void Draw(Display display, WeatherResponse weatherResponse)
        {
            var dt = DateTime.FromUnixTimeSeconds(weatherResponse.Dt).AddSeconds(weatherResponse.Timezone);

            //icon
            display.DrawBitmap(Icon.GetBitmap(weatherResponse.Weather[0].Icon), X, Y, Icon.Width, Icon.Width, Color.White);

            //temp
            display.SetCursor(X + Icon.Width + 5, Y + 3);
            display.SetFontSize(3);
            display.Write(weatherResponse.Main.Temp.ToString("F0"));
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            //feels like
            display.SetCursor(X + Icon.Width + 5, Y + 28 + 3);
            display.SetFontSize(2);
            display.Write(weatherResponse.Main.Feels_Like.ToString("F0"));
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            // conditions
            display.SetCursor(X, Y + Icon.Height + 2);
            display.Write(weatherResponse.Weather[0].Main + " @ " + dt.ToString("HH:mm:ss"));

            display.UpdateWindow(X, Y, display.Width - X, H);
        }
    }
}

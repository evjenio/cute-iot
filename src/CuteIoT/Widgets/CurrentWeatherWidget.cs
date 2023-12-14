using System;
using CuteIoT.Epaper;
using CuteIoT.Services;
using CuteIoT.Resources;

namespace CuteIoT.Widgets
{
    using Icon = Bitmaps.Weather;

    internal class CurrentWeatherWidget
    {
        public int X { get; set; } = 60;
        public int Y { get; set; } = 40;

        public void Draw(Display display, WeatherResponse weatherResponse)
        {
            var dt = DateTime.FromUnixTimeSeconds(weatherResponse.Dt).AddSeconds(weatherResponse.Timezone);

            //icon
            display.DrawBitmap(Icon.GetBitmap(weatherResponse.Weather[0].Icon), X, Y, Icon.Width, Icon.Width, Color.White);

            //temp
            display.SetCursor(X + Icon.Width + 5, Y + 3);
            display.SetFontSize(3);
            display.Write(Math.Round(weatherResponse.Main.Temp).ToString());
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            // wind
            display.AddCursorX(5);
            display.AddCursorY(10);
            display.Write(Math.Round(weatherResponse.Main.Humidity).ToString() + "%");

            //feels like
            display.SetCursor(X + Icon.Width + 5, Y + 31);
            display.SetFontSize(2);
            display.Write(Math.Round(weatherResponse.Main.Feels_Like).ToString());
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            // hum
            display.AddCursorX(5);
            display.AddCursorY(5);
            display.Write(Math.Round(weatherResponse.Wind.Speed).ToString() + "m/s");

            // conditions
            display.SetFontSize(2);
            display.SetCursor(X, Y + Icon.Height + 2);
            display.Write(weatherResponse.Weather[0].Description);
            display.SetFontSize(1);
            display.AddCursorX(5);
            display.AddCursorY(5);
            display.Write(dt.ToString("HH:mm"));

            display.UpdateWindow(X, Y, display.Width - X, display.Height - Y);
        }
    }
}

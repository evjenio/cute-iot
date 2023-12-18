using System;
using CuteIoT.Epaper;
using CuteIoT.Services;
using CuteIoT.Resources;

#nullable enable

namespace CuteIoT.Widgets
{
    using Icon = Bitmaps.Weather;

    internal class CurrentWeatherWidget
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 40;

        public void Draw(Display display, WeatherResponse? weatherResponse)
        {
            if (weatherResponse == null) return;

            // Fill white background
            display.WriteFillRect(X, Y, display.Width - X, display.Height - Y, Color.White);

            var dt = DateTime.FromUnixTimeSeconds(weatherResponse.Dt).AddSeconds(weatherResponse.Timezone);

            //icon
            display.DrawBitmap(Icon.GetBitmap(weatherResponse.Weather[0].Icon), X, Y, Icon.Width, Icon.Width, Color.White);

            //temp
            display.SetCursor(X + Icon.Width + 5, Y + 3);
            display.SetFontSize(4);
            display.Write(((int)Math.Round(weatherResponse.Main.Temp)).ToString());
            display.AddCursorY(-2);
            display.SetFontSize(2);
            display.Write("o");

            display.AddCursorY(2); //rollback

            // hum
            display.SetFontSize(2);
            display.DrawBitmap(Icon.Hygrometer, display.CursorX + 10, display.CursorY, 12, 12, Color.White);
            display.AddCursorX(27);
            display.Write(((int)Math.Round(weatherResponse.Main.Humidity)).ToString() + "%");

            // wind
            display.DrawBitmap(Icon.WindGauge, display.CursorX + 10, display.CursorY, 12, 12, Color.White);
            display.AddCursorX(27);
            display.Write(Math.Round(weatherResponse.Wind.Speed).ToString() + "m/s");

            //feels like
            display.SetCursor(X + Icon.Width + 5, Y + 35);
            display.Write(((int)Math.Round(weatherResponse.Main.Feels_Like)).ToString());
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            display.AddCursorY(2);

            // conditions
            display.AddCursorX(16);
            display.SetFontSize(2);
            display.Write(weatherResponse.Weather[0].Main);

            // timestamp
            display.SetFontSize(1);
            display.SetCursor(X, display.Height - 13);
            display.Write("@ " + dt.ToString("HH:mm"));

            //display.UpdateWindow(X, Y, display.Width - X, display.Height - Y);
        }
    }
}

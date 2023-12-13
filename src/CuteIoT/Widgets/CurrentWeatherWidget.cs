﻿using System;
using CuteIoT.Epaper;
using CuteIoT.Services;

namespace CuteIoT.Widgets
{
    internal class CurrentWeatherWidget
    {
        public int X { get; set; } = 80;
        public int Y { get; set; } = 50;
        private const int H = 48 + 12;
        //private const int W = 2 * 48;
        private const int IconHeight = 48;
        private const int IconWidth = 48;

        private static readonly byte[] Snowflake = {
            // 'free-icon-snowflake-2058415', 48x48px
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x3f, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x0f,
            0xff, 0xff, 0xff, 0xf8, 0x00, 0x07, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x01, 0xff, 0xff, 0xff, 0xe0,
            0x00, 0x01, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x7f, 0xff,
            0xff, 0x80, 0x00, 0x00, 0x3f, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0xff, 0xfc, 0x00, 0x00, 0x00,
            0x00, 0x3f, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x0f, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x07, 0xc0, 0x00,
            0x00, 0x00, 0x00, 0x03, 0xc0, 0x00, 0x01, 0x80, 0x00, 0x03, 0x80, 0x00, 0x07, 0xe0, 0x00, 0x01,
            0x80, 0x00, 0x0f, 0xf0, 0x00, 0x01, 0x80, 0x00, 0x0e, 0x70, 0x00, 0x00, 0x00, 0x00, 0x1e, 0x78,
            0x00, 0x00, 0x00, 0x00, 0x3e, 0x7c, 0x00, 0x00, 0x00, 0x01, 0x78, 0x0e, 0x80, 0x00, 0x00, 0x1f,
            0xf0, 0x0f, 0xf8, 0x00, 0x00, 0x7f, 0xf8, 0x1f, 0xfe, 0x00, 0x00, 0xfe, 0x7c, 0x3e, 0x7f, 0x00,
            0x80, 0xe4, 0x7c, 0x3e, 0x27, 0x01, 0x80, 0xe0, 0x3e, 0x7c, 0x07, 0x01, 0xc0, 0xe0, 0x3c, 0x3c,
            0x07, 0x03, 0xc0, 0xf8, 0x18, 0x18, 0x1f, 0x03, 0xe0, 0x70, 0x00, 0x00, 0x0e, 0x07, 0xf0, 0x70,
            0x01, 0x80, 0x0e, 0x0f, 0xf8, 0x3f, 0xc7, 0xe3, 0xfc, 0x1f, 0xfe, 0x3f, 0xc7, 0xe3, 0xfc, 0x7f,
            0xff, 0xff, 0xc7, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xc7, 0xe3, 0xff, 0xff, 0xff, 0xf9, 0x83, 0xc1,
            0x9f, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x1f, 0xff, 0xff, 0xf0,
            0x3c, 0x3c, 0x0f, 0xff, 0xff, 0xe0, 0x3e, 0x7c, 0x07, 0xff, 0xff, 0xe0, 0x7e, 0x7e, 0x07, 0xff,
            0xff, 0xfe, 0x7c, 0x3e, 0x7f, 0xff, 0xff, 0xff, 0xf8, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f,
            0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff,
            0xfe, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
        };

        public void Draw(Display display, WeatherResponse weatherResponse)
        {
            var dt = DateTime.FromUnixTimeSeconds(weatherResponse.Dt).AddSeconds(weatherResponse.Timezone);

            //icon
            display.DrawBitmap(Snowflake, X, Y, IconWidth, IconHeight, Color.White);

            //temp
            display.SetCursor(X + IconWidth + 5, Y + 3);
            display.SetFontSize(3);
            display.Write(weatherResponse.Main.Temp.ToString("F0"));
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            //feels like
            display.SetCursor(X + IconWidth + 5, Y + 28 + 3);
            display.SetFontSize(2);
            display.Write(weatherResponse.Main.Feels_Like.ToString("F0"));
            display.AddCursorY(-2);
            display.SetFontSize(1);
            display.Write("o");

            // conditions
            display.SetCursor(X, Y + IconHeight + 2);
            display.Write(weatherResponse.Weather[0].Main + " @ " + dt.ToString("HH:mm:ss"));

            display.UpdateWindow(X, Y, display.Width - X - 1, H);
        }
    }
}

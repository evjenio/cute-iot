using System;
using CuteIoT.Epaper;

namespace CuteIoT.Widgets
{
    internal class BatteryWidget
    {
        public int X { get; set; } = 250 - 16;
        public int Y { get; set; } = 0;
        public int H { get; set; } = 16;
        public int W { get; set; } = 16;

        private static readonly byte[] Battery = {
            // 'icons8-battery-16', 16x16px
            0xfc, 0x3f, 0xf1, 0x8f, 0xe7, 0xe7, 0xef, 0xf7, 0xef, 0xf7, 0xef, 0xf7, 0xef, 0xf7, 0xef, 0xf7,
            0xe0, 0x07, 0xe0, 0x07, 0xe0, 0x07, 0xe0, 0x07, 0xe0, 0x07, 0xe0, 0x07, 0xe0, 0x07, 0xf0, 0x0f
        };

        public void Draw(Display display, string voltage)
        {
            const int xOffset = 29;
            display.SetFontSize(1);
            display.SetCursor(X - xOffset, Y + 5);
            display.Write(voltage + "v");
            display.DrawBitmap(Battery, X, Y, W, H, Color.White);
            //display.UpdateWindow(X - xOffset, Y, W + xOffset, H);
        }
    }
}

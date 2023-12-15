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

        private static readonly byte[] Charging = {
            // 'icons8-quick-mode-on-16', 16x16px
            0xff, 0xbf, 0xff, 0x3f, 0xff, 0x3f, 0xfe, 0x7f, 0xfc, 0x7f, 0xfc, 0x7f, 0xf8, 0x07, 0xf0, 0x0f,
            0xf0, 0x0f, 0xe0, 0x1f, 0xfe, 0x1f, 0xfe, 0x3f, 0xfe, 0x7f, 0xfe, 0x7f, 0xfe, 0xff, 0xfe, 0xff
        };

        public void Draw(Display display)
        {
            display.DrawBitmap(Charging, X, Y, W, H, Color.White);
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

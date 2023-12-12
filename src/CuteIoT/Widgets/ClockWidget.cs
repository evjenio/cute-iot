using System;
using CuteIoT.Epaper;
using CuteIoT.Resources;

namespace CuteIoT.Widgets
{
    internal class ClockWidget
    {
        public int X { get; set; } = 24;
        public int Y { get; set; } = 38;
        public int H { get; set; } = Bitmaps.Numbers.Heigth;
        public int W { get; set; } = 24 /*X*/ + 8 + 4 * Bitmaps.Numbers.Width;

        public void Draw(Display display, DateTime datetime)
        {
            int h0 = datetime.Hour / 10;
            int h1 = datetime.Hour % 10;
            int m0 = datetime.Minute / 10;
            int m1 = datetime.Minute % 10;
            display.DrawBitmap(Bitmaps.Numbers.All[h0], X, Y, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[h1], X + 1 + Bitmaps.Numbers.Width, Y, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[m0], X + 7 + 2 * Bitmaps.Numbers.Width, Y, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[m1], X + 8 + 3 * Bitmaps.Numbers.Width, Y, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

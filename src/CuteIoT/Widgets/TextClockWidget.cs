using System;
using CuteIoT.Epaper;

namespace CuteIoT.Widgets
{
    internal class TextClockWidget
    {
        public int X { get; set; } = 100;
        public int Y { get; set; } = 5;
        public int H { get; set; } = 20;
        public int W { get; set; } = 50;

        public void Draw(Display display, DateTime dateTime)
        {
            display.SetCursor(X, Y);
            display.SetFontSize(2);
            display.SetTextColor(Color.Black);
            display.Write(dateTime.ToString("HH:mm"));
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

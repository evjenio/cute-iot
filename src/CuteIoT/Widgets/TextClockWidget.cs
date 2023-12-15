using System;
using CuteIoT.Epaper;

namespace CuteIoT.Widgets
{
    internal class TextClockWidget
    {
        public int X { get; set; } = 54;
        public int Y { get; set; } = 5;
        public int H { get; set; } = 20;
        public int W { get; set; } = 145;

        public void Draw(Display display, DateTime dateTime)
        {
            // Fill white background
            display.WriteFillRect(X, Y, W, H, Color.White);

            display.SetCursor(X, Y);
            display.SetFontSize(2);
            display.SetTextColor(Color.Black);
            display.Write(dateTime.ToString("dd MMM HH:mm"));
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

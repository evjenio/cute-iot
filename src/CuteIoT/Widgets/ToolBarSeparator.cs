using System;
using CuteIoT.Epaper;

namespace CuteIoT.Widgets
{
    internal class ToolBarSeparator
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 25;
        public int H { get; set; } = 1;
        public int W { get; set; } = 250;

        public void Draw(Display display)
        {
            display.WriteFastHLine(X, Y, W, Color.Black);
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

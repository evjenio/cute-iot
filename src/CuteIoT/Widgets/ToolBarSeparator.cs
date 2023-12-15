using System;
using CuteIoT.Epaper;

namespace CuteIoT.Widgets
{
    internal class ToolBarSeparator
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 22;
        public int H { get; set; } = 3;
        public int W { get; set; } = 250;

        public void Draw(Display display)
        {
            display.WriteFastHLine(X, Y, W, Color.Black);
            display.UpdateWindow(X, Y - 1, W, H);
        }
    }
}

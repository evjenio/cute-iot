using System;
using CuteIoT.Epaper;
using CuteIoT.Resources;

namespace CuteIoT.Widgets
{
    internal class LoadingWidget
    {
        public void Draw(Display display)
        {
            display.FillScreen(Color.White);
            display.DrawBitmap(Bitmaps.CuteCat.Bitmap, 95, 40, Bitmaps.CuteCat.Width, Bitmaps.CuteCat.Heigth, Color.White);

            display.SetFontSize(1);

            display.UpdateWindow(0, 0, display.Width, display.Height);
            display.FillScreen(Color.White);
        }
    }
}

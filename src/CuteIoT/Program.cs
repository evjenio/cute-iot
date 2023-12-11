using System;
using System.Threading;
using CuteIoT.Epaper;
using CuteIoT.Resources;

#nullable enable

namespace CuteIoT
{
    public class Program
    {
        private static Display display = null!;

        public static void Main()
        {
            display = new Display();
            display.Init();

            display.SetRotation(1);
            display.FillScreen(Color.Black);
            display.DrawBitmap(Bitmaps.CuteCatSleeping.Bitmap, 0, 0, Bitmaps.CuteCatSleeping.Width, Bitmaps.CuteCatSleeping.Heigth, Color.White);

            display.SetFontSize(2);
            display.SetCursor(2, 2);
            display.SetTextColor(Color.White);
            display.Write("loading...");
            display.UpdateWindow(0, 0, display.Width, display.Height);

            // loading
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var timer = new Timer(RefreshScreen, null, 1000, 1000);
            display.FillScreen(Color.White);
            display.UpdateWindow(0, 0, display.Width, display.Height);


            Thread.Sleep(Timeout.Infinite);
        }

        private static void RefreshScreen(object p)
        {
            display.SetCursor(0, 0);
            display.SetTextColor(Color.Black);
            display.Write(DateTime.UtcNow.ToString("HH:mm:ss"));
            display.UpdateWindow(0, 0, 128, 50);
        }
    }
}

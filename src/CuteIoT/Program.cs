using System;
using System.Threading;
using System.IO;
using CuteIoT.Epaper;
using CuteIoT.Resources;
using nanoFramework.Networking;
using CuteIoT.Widgets;

#nullable enable

namespace CuteIoT
{
    public class Program
    {
        const string Ssid = "Keenetic-7613";
        const int TimeZone = 3;

        private static Display display = null!;

        private static WifiWidget wifiWidget = new();
        private static ToolBarSeparator toolBarSeparator = new();

        public static void Main()
        {
            display = new Display();
            display.Init();
            // loading
            display.SetRotation(1);
            display.FillScreen(Color.White);
            display.DrawBitmap(Bitmaps.CuteCat.Bitmap, 95, 40, Bitmaps.CuteCat.Width, Bitmaps.CuteCat.Heigth, Color.White);

            display.SetFontSize(1);

            display.UpdateWindow(0, 0, display.Width, display.Height);
            display.FillScreen(Color.White);


            Thread.Sleep(1000);
            string password;
            try
            {
                using var file = File.OpenText("I:\\wifi.txt");
                password = file.ReadToEnd();
            }
            catch (Exception e)
            {
                display.Write(e.Message);
                display.UpdateWindow(0, 0, 250, 20);
                Thread.Sleep(Timeout.Infinite);
                return;
            }

            // connecting
            bool connected;
            do
            {
                connected = WifiNetworkHelper.ConnectDhcp(Ssid, password);
                toolBarSeparator.Draw(display);
                wifiWidget.Draw(display);
                if (!connected)
                {
                    Thread.Sleep(TimeSpan.FromMinutes(1));
                }
            } while (!connected);

            var timer = new Timer(RefreshScreen, null, TimeSpan.FromMinutes(1).Subtract(TimeSpan.FromSeconds(DateTime.UtcNow.Second)), TimeSpan.FromMinutes(1));

            Thread.Sleep(Timeout.Infinite);
        }

        private static void RefreshScreen(object p)
        {
            var datetime = DateTime.UtcNow.AddHours(TimeZone);
            // DrawTextClock(datetime);
            DrawClock(datetime);

            display.UpdateWindow(0, 0, display.Width, display.Height);
        }

        private static void DrawTextClock(DateTime datetime)
        {
            display.SetCursor(0, 0);
            display.SetTextColor(Color.Black);
            display.Write(datetime.ToString("HH:mm"));
        }

        private static void DrawClock(DateTime datetime)
        {
            int h0 = datetime.Hour / 10;
            int h1 = datetime.Hour % 10;
            int m0 = datetime.Minute / 10;
            int m1 = datetime.Minute % 10;
            const int xOffset = 24;
            const int yOffset = 38;
            display.DrawBitmap(Bitmaps.Numbers.All[h0], xOffset, yOffset, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[h1], xOffset + 1 + Bitmaps.Numbers.Width, yOffset, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[m0], xOffset + 7 + 2 * Bitmaps.Numbers.Width, yOffset, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
            display.DrawBitmap(Bitmaps.Numbers.All[m1], xOffset + 8 + 3 * Bitmaps.Numbers.Width, yOffset, Bitmaps.Numbers.Width, Bitmaps.Numbers.Heigth, Color.White);
        }
    }
}

using System;
using CuteIoT.Epaper;
using nanoFramework.Networking;

namespace CuteIoT.Widgets
{
    internal class WifiWidget
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int H { get; set; } = 16;
        public int W { get; set; } = 16;

        private static readonly byte[] Online = {
            // 'icons8-online-16', 16x16px
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xcf, 0xf3, 0xcf, 0xf3, 0x99, 0x99, 0x93, 0xc9, 0x92, 0x49,
            0x92, 0x49, 0x93, 0xc9, 0x99, 0x99, 0xcf, 0xf3, 0xcf, 0xf3, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
        };

        private static readonly byte[] Offline = {
            // 'icons8-offline-16', 16x16px
            0x7f, 0xff, 0xbf, 0xff, 0xcf, 0xff, 0xef, 0xf3, 0xf3, 0xf1, 0x99, 0x99, 0x9d, 0xc9, 0x96, 0x49,
            0x93, 0x49, 0x93, 0x89, 0x99, 0xc9, 0xcf, 0xe3, 0xcf, 0xf3, 0xff, 0xfb, 0xff, 0xfd, 0xff, 0xfe
        };

        public void Draw(Display display)
        {
            if (WifiNetworkHelper.Status == NetworkHelperStatus.NetworkIsReady)
            {
                display.DrawBitmap(Online, X, Y, W, H, Color.White);
            }
            else
            {
                display.DrawBitmap(Offline, X, Y, W, H, Color.White);
            }
            display.UpdateWindow(X, Y, W, H);
        }
    }
}

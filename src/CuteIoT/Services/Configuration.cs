﻿using System;

namespace CuteIoT.Services
{
    internal class Configuration
    {
        public double Timezone { get; set; }
        public string Ssid { get; set; }
        public string Password { get; set; }
        public string CurrentWeaterApiUrl { get; set; }
    }
}

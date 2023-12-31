﻿using System;
using System.Device.Adc;
using System.Diagnostics;

namespace CuteIoT.Services
{
    internal class BatteryService
    {
        private readonly AdcController _adc;
        
        public BatteryService()
        {
            _adc = new AdcController();
        }

        public double ReadVoltage()
        {
            using var channel = _adc.OpenChannel(7);
            var value = channel.ReadValue();
            var batteryVoltage = (value / 4095.0 * 2.0 * 3.3 * (1100 / 1000.0));

            Debug.WriteLine("Battery: " + batteryVoltage.ToString("F2") + "v");
            return batteryVoltage;
        }
    }
}

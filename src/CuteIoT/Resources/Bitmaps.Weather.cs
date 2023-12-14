﻿using System;

namespace CuteIoT.Resources
{
    public static partial class Bitmaps
    {
        public static class Weather
        {
            public const int Height = 48;
            public const int Width = 48;

            private static readonly byte[] Sun = {
                // 'icons8-sun-48', 48x48px
                0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f,
                0xff, 0xff, 0xff, 0xf3, 0xfc, 0x3f, 0xcf, 0xff, 0xff, 0xe1, 0xfc, 0x3f, 0x87, 0xff, 0xff, 0xe1,
                0xfc, 0x3f, 0x87, 0xff, 0xff, 0xf0, 0xfc, 0x3f, 0x0f, 0xff, 0xff, 0xf0, 0x7c, 0x3e, 0x0f, 0xff,
                0xff, 0xf8, 0x7e, 0x7e, 0x1f, 0xff, 0xff, 0xf8, 0x3f, 0xfc, 0x1f, 0xff, 0xff, 0xfc, 0x7f, 0xfe,
                0x3f, 0xff, 0xf3, 0xff, 0xf8, 0x1f, 0xff, 0xc7, 0xe0, 0xff, 0xc0, 0x03, 0xff, 0x07, 0xe0, 0x3f,
                0x80, 0x01, 0xfc, 0x07, 0xf0, 0x1e, 0x00, 0x00, 0x78, 0x0f, 0xfc, 0x1c, 0x0f, 0xf0, 0x38, 0x3f,
                0xfe, 0x1c, 0x1f, 0xf8, 0x38, 0x7f, 0xff, 0xb8, 0x7f, 0xfc, 0x1d, 0xff, 0xff, 0xf0, 0x7f, 0xfe,
                0x0f, 0xff, 0xff, 0xf0, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xf1, 0xff, 0xff, 0x8f, 0xff, 0xff, 0xe1,
                0xff, 0xff, 0x87, 0xff, 0x80, 0xe1, 0xff, 0xff, 0x86, 0x01, 0x00, 0x61, 0xff, 0xff, 0x86, 0x00,
                0x00, 0x61, 0xff, 0xff, 0x86, 0x00, 0x80, 0xe1, 0xff, 0xff, 0x86, 0x01, 0xff, 0xe1, 0xff, 0xff,
                0x87, 0xff, 0xff, 0xf1, 0xff, 0xff, 0x8f, 0xff, 0xff, 0xf0, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xf0,
                0x7f, 0xfe, 0x0f, 0xff, 0xff, 0xb8, 0x3f, 0xfc, 0x1d, 0xff, 0xfe, 0x1c, 0x1f, 0xf8, 0x38, 0x7f,
                0xfc, 0x0c, 0x0f, 0xf0, 0x38, 0x3f, 0xf0, 0x1e, 0x00, 0x00, 0x78, 0x0f, 0xe0, 0x3f, 0x80, 0x01,
                0xfc, 0x07, 0xe0, 0xff, 0xc0, 0x03, 0xff, 0x07, 0xf3, 0xff, 0xf8, 0x1f, 0xff, 0xcf, 0xff, 0xfc,
                0x7f, 0xfe, 0x3f, 0xff, 0xff, 0xf8, 0x7f, 0xfc, 0x1f, 0xff, 0xff, 0xf8, 0x7e, 0x7e, 0x1f, 0xff,
                0xff, 0xf0, 0x7c, 0x3e, 0x0f, 0xff, 0xff, 0xf0, 0xfc, 0x3f, 0x0f, 0xff, 0xff, 0xe1, 0xfc, 0x3f,
                0x87, 0xff, 0xff, 0xe1, 0xfc, 0x3f, 0x87, 0xff, 0xff, 0xf3, 0xfc, 0x3f, 0xcf, 0xff, 0xff, 0xff,
                0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff
            };

            private static readonly byte[] Moon = { 
                // 'icons8-moon-and-stars-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x03, 0xff, 0xff, 0xff, 0xff, 0xfc,
                0x07, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x07, 0xff, 0xff, 0xff,
                0xff, 0xf8, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf7, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xff, 0xff, 0xf7, 0xff, 0x80, 0xff, 0xff, 0xff, 0xf9, 0xff,
                0xc1, 0xff, 0xff, 0xff, 0xfc, 0x7f, 0xc1, 0xff, 0xff, 0xff, 0xfe, 0x3f, 0x80, 0xff, 0xff, 0xff,
                0xff, 0x1f, 0xf7, 0xff, 0xff, 0xff, 0xff, 0x0f, 0xf7, 0xff, 0xff, 0xff, 0xff, 0x87, 0xff, 0xff,
                0xff, 0xff, 0xff, 0x87, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc3,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0x81, 0xff, 0xff, 0xff, 0xff,
                0xff, 0x81, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0xff, 0xfd, 0xff, 0xff, 0xfe, 0x01, 0xff, 0xfe,
                0xff, 0xff, 0xfe, 0x03, 0xff, 0xfe, 0x7f, 0xff, 0xfc, 0x03, 0xff, 0xff, 0x3f, 0xff, 0xf0, 0x07,
                0xff, 0xff, 0x0f, 0xff, 0xe0, 0x0f, 0xff, 0xff, 0x83, 0xff, 0x80, 0x0f, 0xff, 0xff, 0xc0, 0x38,
                0x00, 0x1f, 0xff, 0xff, 0xe0, 0x00, 0x00, 0x3f, 0xff, 0xff, 0xf0, 0x00, 0x00, 0xff, 0xff, 0xff,
                0xfc, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0x00, 0x07, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x7f, 0xff
            };

            private static readonly byte[] FewCloudsDay = {
                // 'icons8-partly-cloudy-day-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0xff,
                0xff, 0xff, 0xff, 0x3f, 0x3e, 0x7f, 0xff, 0xff, 0xff, 0x1f, 0x3c, 0x7f, 0xff, 0xff, 0xff, 0x9f,
                0x3c, 0xff, 0xff, 0xff, 0xff, 0x8f, 0x38, 0xff, 0xff, 0xff, 0xff, 0xc6, 0x39, 0xff, 0xff, 0xff,
                0xe7, 0xe0, 0x01, 0xf3, 0xff, 0xff, 0xe1, 0xe0, 0x01, 0xe1, 0xff, 0xff, 0xf0, 0xc0, 0x00, 0x87,
                0xff, 0xff, 0xfc, 0x01, 0xe0, 0x0f, 0xff, 0xff, 0xfe, 0x07, 0xf0, 0x3f, 0xff, 0xff, 0xff, 0x0f,
                0xfb, 0xf0, 0x1f, 0xff, 0xff, 0x0f, 0xff, 0xc0, 0x07, 0xff, 0xfe, 0x1f, 0xff, 0x00, 0x03, 0xff,
                0x80, 0x1f, 0xfe, 0x00, 0x01, 0xff, 0x80, 0x1f, 0xfe, 0x0f, 0xe0, 0xff, 0xff, 0x1f, 0xf4, 0x1f,
                0xf0, 0x7f, 0xff, 0x0f, 0x00, 0x3f, 0xf8, 0x7f, 0xff, 0x1e, 0x00, 0x7f, 0xfc, 0x3f, 0xfc, 0x3c,
                0x00, 0xff, 0xfc, 0x3f, 0xf0, 0x78, 0x3c, 0xff, 0xfe, 0x3f, 0xe1, 0xf0, 0x7f, 0xff, 0xfe, 0x1f,
                0xe7, 0xf0, 0xff, 0xff, 0xfe, 0x07, 0xff, 0xe1, 0xff, 0xff, 0xfe, 0x03, 0xff, 0x01, 0xff, 0xff,
                0xff, 0x83, 0xfc, 0x01, 0xff, 0xff, 0xff, 0xe1, 0xf8, 0x01, 0xff, 0xff, 0xff, 0xe1, 0xf8, 0x01,
                0xff, 0xff, 0xff, 0xf0, 0xf0, 0x7d, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xf0,
                0xf0, 0xff, 0xff, 0xff, 0xff, 0xf0, 0xf1, 0xff, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xff, 0xff, 0xff,
                0xff, 0xe1, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xf0, 0x7f, 0xff, 0xff, 0xff, 0x83, 0xf8, 0x00,
                0x00, 0x00, 0x00, 0x03, 0xfc, 0x00, 0x00, 0x00, 0x00, 0x07, 0xfe, 0x00, 0x00, 0x00, 0x00, 0x1f,
                0xff, 0xc0, 0x00, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
            };

            private static readonly byte[] FewCloudsNight = {
                // 'icons8-night-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0xff,
                0xfb, 0xff, 0xff, 0xff, 0x8f, 0xff, 0xf9, 0xff, 0xff, 0xff, 0xc7, 0xff, 0xe0, 0x7f, 0xff, 0xff,
                0xc3, 0xff, 0xf0, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xe0, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xc0, 0x7f,
                0xff, 0xff, 0xe1, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xe0, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xe0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x83, 0xf0, 0x1f, 0xff, 0xff, 0xff, 0x87, 0xc0, 0x07, 0xff, 0xff, 0xff, 0x0f, 0x00, 0x03, 0xff,
                0x9f, 0xfe, 0xfe, 0x00, 0x01, 0xff, 0x8f, 0xff, 0xfe, 0x0f, 0xe0, 0xff, 0xc0, 0xe7, 0xf4, 0x1f,
                0xf0, 0x7f, 0xe0, 0x0f, 0x00, 0x3f, 0xf8, 0x7f, 0xf0, 0x1e, 0x00, 0x7f, 0xfc, 0x3f, 0xf8, 0x3c,
                0x00, 0xff, 0xfc, 0x3f, 0xfc, 0x38, 0x3c, 0xff, 0xfe, 0x3f, 0xff, 0xf0, 0x7f, 0xff, 0xfe, 0x1f,
                0xff, 0xf0, 0xff, 0xff, 0xfe, 0x07, 0xff, 0xe1, 0xff, 0xff, 0xfe, 0x03, 0xff, 0x01, 0xff, 0xff,
                0xff, 0x83, 0xfc, 0x01, 0xff, 0xff, 0xff, 0xe1, 0xf8, 0x01, 0xff, 0xff, 0xff, 0xe1, 0xf8, 0x01,
                0xff, 0xff, 0xff, 0xf0, 0xf0, 0x7d, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xf0,
                0xf0, 0xff, 0xff, 0xff, 0xff, 0xf0, 0xf1, 0xff, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xff, 0xff, 0xff,
                0xff, 0xe1, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xf0, 0x7f, 0xff, 0xff, 0xff, 0x83, 0xf8, 0x00,
                0x00, 0x00, 0x00, 0x03, 0xfc, 0x00, 0x00, 0x00, 0x00, 0x07, 0xfe, 0x00, 0x00, 0x00, 0x00, 0x1f,
                0xff, 0xc0, 0x00, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
            };

            private static readonly byte[] Clouds = {
                // 'icons8-clouds-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x1f, 0xff,
                0xff, 0xff, 0xf8, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xf0, 0x1e, 0x07, 0xff, 0xff, 0xff, 0xe0, 0xff,
                0x83, 0xff, 0xff, 0xfe, 0x01, 0xff, 0xc1, 0xff, 0xff, 0xf8, 0x03, 0xff, 0xe1, 0xff, 0xff, 0xe0,
                0x07, 0xff, 0xf0, 0xff, 0xff, 0xc0, 0x07, 0xff, 0xf0, 0xff, 0xff, 0x81, 0xff, 0xff, 0xf8, 0x7f,
                0xff, 0x87, 0xff, 0xff, 0xf8, 0x1f, 0xff, 0x0f, 0xff, 0xff, 0xf8, 0x07, 0xff, 0x0f, 0xff, 0xff,
                0xfc, 0x03, 0xf0, 0x1f, 0xff, 0xff, 0xff, 0x83, 0xe0, 0x1f, 0xff, 0xff, 0xff, 0xe1, 0xc0, 0x1f,
                0xff, 0xff, 0xff, 0xe1, 0x81, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x87, 0xff, 0xff, 0xff, 0xff, 0xf0,
                0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff,
                0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1, 0x07, 0xff,
                0xff, 0xff, 0xff, 0xc1, 0x83, 0xff, 0xff, 0xff, 0xff, 0x83, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x03,
                0xc0, 0x00, 0x00, 0x00, 0x00, 0x07, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x1f, 0xf8, 0x00, 0x00, 0x00,
                0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
            };

            private static readonly byte[] Rain = {
                // 'icons8-rain-48', 48x48px
                0xff, 0xff, 0xff, 0x80, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xfc, 0x00,
                0x0f, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x07, 0xff, 0xff, 0xff, 0xf0, 0x7f, 0x03, 0xff, 0xff, 0xff,
                0xe1, 0xff, 0xc3, 0xff, 0xff, 0xf8, 0x03, 0xff, 0xe1, 0xff, 0xff, 0xf0, 0x03, 0xff, 0xf0, 0xff,
                0xff, 0xe0, 0x07, 0xff, 0xf0, 0xff, 0xff, 0xc0, 0xef, 0xff, 0xf0, 0xff, 0xff, 0x83, 0xff, 0xff,
                0xf8, 0x3f, 0xff, 0x87, 0xff, 0xff, 0xf8, 0x0f, 0xff, 0x0f, 0xff, 0xff, 0xf8, 0x07, 0xf8, 0x0f,
                0xff, 0xff, 0xff, 0x03, 0xf0, 0x1f, 0xff, 0xff, 0xff, 0xc1, 0xc0, 0x1f, 0xff, 0xff, 0xff, 0xe1,
                0xc0, 0x1f, 0xff, 0xff, 0xff, 0xf0, 0x83, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x07, 0xff, 0xff, 0xff,
                0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff,
                0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1,
                0x87, 0xff, 0xff, 0xff, 0xff, 0xc1, 0x81, 0xff, 0xff, 0xff, 0xff, 0x03, 0xc0, 0x00, 0x00, 0x00,
                0x00, 0x07, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x0f, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x3f, 0xff, 0x00,
                0x00, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfd, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xf1, 0xff, 0xff, 0xf7, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xc7, 0xff, 0xff,
                0x01, 0xff, 0xff, 0x07, 0xff, 0xff, 0x01, 0xff, 0xfc, 0x07, 0xff, 0xfe, 0x01, 0xff, 0xfc, 0x07,
                0xff, 0xfe, 0x03, 0xff, 0xfc, 0x07, 0xff, 0xff, 0x03, 0xff, 0xfc, 0x07, 0xff, 0x3f, 0x07, 0xff,
                0xfc, 0x0f, 0xfc, 0x3f, 0xff, 0xff, 0xfe, 0x1f, 0xf0, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x3f,
                0xff, 0xff, 0xff, 0xff, 0xe0, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x3f, 0xff, 0xff, 0xff, 0xff,
                0xe0, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xf1, 0xff, 0xff, 0xff
            };

            private static readonly byte[] RainCloud = {
                // 'icons8-rain-cloud-48', 48x48px
                0xff, 0xff, 0xff, 0x80, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xfc, 0x00,
                0x0f, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x07, 0xff, 0xff, 0xff, 0xf0, 0x7f, 0x03, 0xff, 0xff, 0xff,
                0xe1, 0xff, 0xc3, 0xff, 0xff, 0xf8, 0x03, 0xff, 0xe1, 0xff, 0xff, 0xf0, 0x03, 0xff, 0xf0, 0xff,
                0xff, 0xe0, 0x07, 0xff, 0xf0, 0xff, 0xff, 0xc0, 0xef, 0xff, 0xf0, 0xff, 0xff, 0x83, 0xff, 0xff,
                0xf8, 0x3f, 0xff, 0x87, 0xff, 0xff, 0xf8, 0x0f, 0xff, 0x0f, 0xff, 0xff, 0xf8, 0x07, 0xf8, 0x0f,
                0xff, 0xff, 0xff, 0x03, 0xf0, 0x1f, 0xff, 0xff, 0xff, 0xc1, 0xc0, 0x1f, 0xff, 0xff, 0xff, 0xe1,
                0xc0, 0x1f, 0xff, 0xff, 0xff, 0xf0, 0x83, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x07, 0xff, 0xff, 0xff,
                0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff,
                0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1,
                0x87, 0xff, 0xff, 0xff, 0xff, 0xc1, 0x81, 0xff, 0xff, 0xff, 0xff, 0x03, 0xc0, 0x00, 0x00, 0x00,
                0x00, 0x07, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x0f, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x3f, 0xff, 0x00,
                0x00, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc7,
                0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x07, 0xff, 0xff, 0xff, 0xff,
                0xfc, 0x07, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x07, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x07, 0xff, 0xff,
                0xff, 0xff, 0xfe, 0x07, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
            };

            private static readonly byte[] Stormy = {
                // 'icons8-stormy-weather-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0xff,
                0xff, 0xff, 0xff, 0x3f, 0x3e, 0x7f, 0xff, 0xff, 0xff, 0x1f, 0x3c, 0x7f, 0xff, 0xff, 0xff, 0x9f,
                0x3c, 0xff, 0xff, 0xff, 0xff, 0x8f, 0x38, 0xff, 0xff, 0xff, 0xff, 0xc6, 0x39, 0xff, 0xff, 0xff,
                0xe7, 0xe0, 0x01, 0xf3, 0xff, 0xff, 0xe1, 0xe0, 0x01, 0xe1, 0xff, 0xff, 0xf0, 0xc0, 0x00, 0x87,
                0xff, 0xff, 0xfc, 0x01, 0xe0, 0x0f, 0xff, 0xff, 0xfe, 0x07, 0xf0, 0x3f, 0xff, 0xff, 0xff, 0x0f,
                0xfb, 0xfe, 0x07, 0xff, 0xff, 0x0f, 0xff, 0xf8, 0x01, 0xff, 0xfe, 0x1f, 0xff, 0xf0, 0x00, 0xff,
                0x80, 0x1f, 0xff, 0xe0, 0x00, 0x7f, 0x80, 0x1f, 0xff, 0xc1, 0xf8, 0x3f, 0xff, 0x1f, 0xf0, 0x07,
                0xfc, 0x3f, 0xff, 0x0f, 0xc0, 0x07, 0xfe, 0x1f, 0xff, 0x1f, 0x80, 0x0f, 0xfe, 0x1f, 0xfc, 0x3f,
                0x81, 0x8f, 0xfe, 0x1f, 0xf0, 0x7f, 0x07, 0xff, 0xff, 0x0f, 0xe1, 0xff, 0x0f, 0xff, 0xff, 0x03,
                0xe7, 0xf8, 0x1f, 0xff, 0xff, 0x81, 0xff, 0xe0, 0x1f, 0xff, 0xff, 0xe1, 0xff, 0xe0, 0x1f, 0xff,
                0xff, 0xf0, 0xff, 0xc0, 0x1f, 0xff, 0xff, 0xf0, 0xff, 0xc3, 0xff, 0xf0, 0x7f, 0xf0, 0xff, 0x87,
                0xff, 0xf0, 0xff, 0xf0, 0xff, 0x87, 0xff, 0xe0, 0xff, 0xf0, 0xff, 0x87, 0xff, 0xe1, 0xff, 0xe0,
                0xff, 0xc3, 0xff, 0xc1, 0xff, 0xc1, 0xff, 0xc0, 0x03, 0xc3, 0xf0, 0x03, 0xff, 0xe0, 0x03, 0xc3,
                0xf0, 0x03, 0xff, 0xf0, 0x03, 0x80, 0x70, 0x0f, 0xff, 0xfc, 0x03, 0x80, 0xf0, 0x3f, 0xff, 0xff,
                0xff, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0x81, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe1, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xe3, 0xff, 0x3f, 0xff, 0xff, 0xbf, 0xe7, 0xfc, 0x3f, 0xff, 0xfe, 0x3f, 0xe7,
                0xf8, 0x3f, 0xff, 0xfc, 0x3f, 0xef, 0xf8, 0x3f, 0xff, 0xf8, 0x3f, 0xcf, 0xf8, 0x3f, 0xff, 0xf8,
                0x3f, 0xdf, 0xfc, 0x7f, 0xff, 0xf8, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x7f, 0xff, 0xff, 0xff
            };

            private static readonly byte[] Thunderstorm = {
                // 'icons8-storm-48', 48x48px
                0xff, 0xff, 0xff, 0x80, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xfc, 0x00,
                0x0f, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x07, 0xff, 0xff, 0xff, 0xf0, 0x7f, 0x03, 0xff, 0xff, 0xff,
                0xe1, 0xff, 0xc3, 0xff, 0xff, 0xf8, 0x03, 0xff, 0xe1, 0xff, 0xff, 0xf0, 0x03, 0xff, 0xf0, 0xff,
                0xff, 0xe0, 0x07, 0xff, 0xf0, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xf0, 0xff, 0xff, 0x83, 0xff, 0xff,
                0xf8, 0x3f, 0xff, 0x87, 0xff, 0xff, 0xf8, 0x0f, 0xff, 0x0f, 0xff, 0xff, 0xfc, 0x07, 0xf8, 0x0f,
                0xff, 0xff, 0xff, 0x03, 0xf0, 0x1f, 0xff, 0xff, 0xff, 0xc1, 0xc0, 0x1f, 0xff, 0xff, 0xff, 0xe1,
                0xc0, 0x3f, 0xff, 0xff, 0xff, 0xf0, 0x83, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x07, 0xff, 0xff, 0xff,
                0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff,
                0xff, 0xff, 0xff, 0xf0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xe1,
                0x87, 0xff, 0xfc, 0x1f, 0xff, 0xc1, 0x81, 0xff, 0xf8, 0x1f, 0xff, 0x03, 0xc0, 0x00, 0xf8, 0x38,
                0x00, 0x07, 0xe0, 0x00, 0xf0, 0x38, 0x00, 0x0f, 0xf0, 0x00, 0xf0, 0x78, 0x00, 0x3f, 0xff, 0x03,
                0xf0, 0x7e, 0x03, 0xff, 0xff, 0xff, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xe1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x1f,
                0xff, 0xff, 0xff, 0xff, 0x80, 0x3f, 0xff, 0xff, 0xff, 0xff, 0x80, 0x3f, 0xff, 0xff, 0xff, 0xff,
                0xf8, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xf8, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xf1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf3, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
            };

            private static readonly byte[] Snowflake = {
                // 'icons8-winter-48', 48x48px
                0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f,
                0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0x8c, 0x31, 0xff, 0xff, 0xff, 0xff,
                0x84, 0x21, 0xff, 0xff, 0xff, 0xff, 0x80, 0x01, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x03, 0xff, 0xff,
                0xff, 0xcf, 0xe0, 0x07, 0xf3, 0xff, 0xff, 0x87, 0xf0, 0x0f, 0xe1, 0xff, 0xff, 0x87, 0xf8, 0x1f,
                0xe1, 0xff, 0xf3, 0x87, 0xfc, 0x3f, 0xe1, 0xc7, 0xe0, 0xc7, 0xfc, 0x3f, 0xe3, 0x07, 0xe0, 0x03,
                0xfc, 0x3f, 0xc0, 0x07, 0xf0, 0x03, 0xfc, 0x3f, 0xc0, 0x0f, 0xfc, 0x03, 0xfc, 0x3f, 0xc0, 0x1f,
                0xfe, 0x01, 0xfc, 0x3f, 0x80, 0x7f, 0xfc, 0x00, 0xfc, 0x3f, 0x00, 0x3f, 0xf0, 0x00, 0x3c, 0x3c,
                0x00, 0x0f, 0xe0, 0x00, 0x0c, 0x30, 0x00, 0x07, 0xf0, 0x7c, 0x00, 0x00, 0x3e, 0x0f, 0xff, 0xff,
                0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x03, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x07, 0xff, 0xff,
                0xff, 0xff, 0xe0, 0x07, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x03, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00,
                0xff, 0xff, 0xf0, 0x7c, 0x00, 0x00, 0x3e, 0x07, 0xe0, 0x00, 0x0c, 0x30, 0x00, 0x07, 0xf0, 0x00,
                0x3c, 0x3c, 0x00, 0x0f, 0xfc, 0x00, 0xfc, 0x3f, 0x00, 0x3f, 0xfe, 0x01, 0xfc, 0x3f, 0x80, 0x7f,
                0xfc, 0x03, 0xfc, 0x3f, 0xc0, 0x1f, 0xf0, 0x03, 0xfc, 0x3f, 0xc0, 0x0f, 0xe0, 0x03, 0xfc, 0x3f,
                0xc0, 0x07, 0xe0, 0xc7, 0xfc, 0x3f, 0xe3, 0x07, 0xf3, 0x87, 0xfc, 0x3f, 0xe1, 0xcf, 0xff, 0x87,
                0xf8, 0x1f, 0xe1, 0xff, 0xff, 0x87, 0xf0, 0x0f, 0xe1, 0xff, 0xff, 0xcf, 0xe0, 0x07, 0xf3, 0xff,
                0xff, 0xff, 0xc0, 0x03, 0xff, 0xff, 0xff, 0xff, 0x80, 0x01, 0xff, 0xff, 0xff, 0xff, 0x84, 0x21,
                0xff, 0xff, 0xff, 0xff, 0x8c, 0x31, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff,
                0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff
            };

            private static readonly byte[] FogDay = {
                // 'icons8-haze-48', 48x48px
                0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f,
                0xff, 0xff, 0xff, 0xf3, 0xfc, 0x3f, 0xcf, 0xff, 0xff, 0xe1, 0xfc, 0x3f, 0x87, 0xff, 0xff, 0xe1,
                0xfc, 0x3f, 0x87, 0xff, 0xff, 0xf0, 0xfc, 0x3f, 0x0f, 0xff, 0xff, 0xf0, 0x7c, 0x3e, 0x0f, 0xff,
                0xff, 0xf8, 0x7e, 0x7e, 0x1f, 0xff, 0xff, 0xf8, 0x38, 0x1c, 0x1f, 0xff, 0xff, 0xfc, 0x00, 0x00,
                0x3f, 0xff, 0xf3, 0xfe, 0x00, 0x00, 0x7f, 0xc7, 0xe0, 0xfe, 0x00, 0x00, 0x7f, 0x07, 0xe0, 0x3c,
                0x07, 0xe0, 0x3c, 0x07, 0xf0, 0x18, 0x3f, 0xfc, 0x18, 0x0f, 0xfc, 0x00, 0x7f, 0xfe, 0x00, 0x3f,
                0xfe, 0x00, 0xff, 0xff, 0x00, 0x7f, 0xff, 0x81, 0xff, 0xff, 0x81, 0xff, 0xff, 0xc3, 0xff, 0xff,
                0xc3, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xc3, 0xff, 0xff, 0x87,
                0xff, 0xff, 0xe1, 0xff, 0x80, 0x00, 0x00, 0x1f, 0xe0, 0x01, 0x00, 0x00, 0x00, 0x0f, 0xe0, 0x00,
                0x00, 0x00, 0x00, 0x0f, 0xe0, 0x00, 0x80, 0x00, 0x00, 0x1f, 0xe0, 0x01, 0xff, 0xff, 0xff, 0xff,
                0xe1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe3, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x00, 0x00, 0x7d, 0xff, 0xf8, 0x00, 0x00, 0x00, 0x78, 0x7f,
                0xfc, 0x00, 0x00, 0x00, 0x78, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x0f, 0xff, 0xff, 0xff, 0xff,
                0xfc, 0x07, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0xff, 0xff, 0xff, 0xff, 0xff, 0xcf, 0x00, 0x00,
                0x00, 0x1e, 0x3f, 0xff, 0x00, 0x00, 0x00, 0x0c, 0x1f, 0xff, 0x00, 0x00, 0x00, 0x1e, 0x1f, 0xff,
                0x80, 0x00, 0x00, 0x3e, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x87, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0x87, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xcf, 0xff, 0xff, 0xff,
                0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x7f, 0xff, 0xff
            };

            private static readonly byte[] FogNight = {
                // 'icons8-fog-48', 48x48px
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xf3, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x7f, 0xff, 0xff, 0xff, 0xff,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x7f, 0xff, 0xff,
                0xff, 0xff, 0x80, 0x3f, 0xff, 0xff, 0xf7, 0xff, 0xf3, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xfb, 0xff,
                0xff, 0xff, 0x80, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xc0, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xf7, 0xff, 0xff, 0xff, 0xf9, 0xff,
                0xf7, 0xff, 0xff, 0xff, 0xfc, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x3f, 0xff, 0xff, 0xff, 0xff,
                0xff, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x87, 0xff, 0xff,
                0xff, 0xff, 0xff, 0x87, 0x80, 0x00, 0x00, 0x1f, 0xff, 0xc3, 0x00, 0x00, 0x00, 0x0f, 0xff, 0xc3,
                0x00, 0x00, 0x00, 0x0f, 0xff, 0xc1, 0x80, 0x00, 0x00, 0x1f, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc1, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xc0, 0xfc, 0x00, 0x00, 0x00, 0x7f, 0xc0, 0xf8, 0x00, 0x00, 0x00, 0x7f, 0xc0,
                0xfc, 0x00, 0x00, 0x00, 0x7f, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0x81, 0xff, 0xff, 0xff, 0xff,
                0xff, 0x81, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x01, 0x00, 0x00,
                0x00, 0x1f, 0xfe, 0x03, 0x00, 0x00, 0x00, 0x0f, 0xfc, 0x03, 0x00, 0x00, 0x00, 0x1f, 0xf0, 0x07,
                0x80, 0x00, 0x00, 0x3f, 0xe0, 0x0f, 0xff, 0xff, 0xff, 0xff, 0x80, 0x0f, 0xff, 0xff, 0xe0, 0x38,
                0x00, 0x1f, 0xff, 0xff, 0xe0, 0x00, 0x00, 0x3f, 0xff, 0xff, 0xf0, 0x00, 0x00, 0xff, 0xff, 0xff,
                0xfc, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0x00, 0x07, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x7f, 0xff
            };

            public static byte[] GetBitmap(string iconName)
            {
                return iconName switch
                {
                    "01d" => Sun,
                    "01n" => Moon,
                    "02d" => FewCloudsDay,
                    "02n" => FewCloudsNight,
                    "03d" => Clouds,
                    "03n" => Clouds,
                    "04d" => Clouds,
                    "04n" => Clouds,
                    "09d" => Rain,
                    "09n" => Rain,
                    "10d" => RainCloud,
                    "10n" => RainCloud,
                    "11d" => Stormy,
                    "11n" => Thunderstorm,
                    "13d" => Snowflake,
                    "13n" => Snowflake,
                    "50d" => FogDay,
                    "50n" => FogNight,
                    _ => throw new ArgumentException()
                };
            }
        }
    }
}
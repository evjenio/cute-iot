using System;

namespace CuteIoT.Services
{
    internal class WeatherResponse
    {
        public WeatherModel[] Weather { get; set; }
        public MainModel Main { get; set; }
        public WindModel Wind { get; set; }
        public long Dt { get; set; }
        public int Timezone { get; set; }

    }

    internal class MainModel
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Humidity { get; set; }
    }

    internal class WindModel
    {
        public double Speed { get; set; }
    }

    internal class WeatherModel
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }

    //   {
    //  "coord": {
    //    "lon": 37.5295,
    //    "lat": 55.9383
    //  },
    //  "weather": [
    //    {
    //      "id": 600,
    //      "main": "Snow",
    //      "description": "light snow",
    //      "icon": "13n"
    //    }
    //  ],
    //  "base": "stations",
    //  "main": {
    //    "temp": -9.33,
    //    "feels_like": -16.33,
    //    "temp_min": -10.19,
    //    "temp_max": -8.37,
    //    "pressure": 1018,
    //    "humidity": 78
    //  },
    //  "visibility": 10000,
    //  "wind": {
    //    "speed": 7.15,
    //    "deg": 140,
    //    "gust": 0
    //  },
    //  "snow": {
    //    "1h": 0.11
    //  },
    //  "clouds": {
    //    "all": 40
    //  },
    //  "dt": 1702413526,
    //  "sys": {
    //    "type": 2,
    //    "id": 47754,
    //    "country": "RU",
    //    "sunrise": 1702360275,
    //    "sunset": 1702385741
    //  },
    //  "timezone": 10800,
    //  "id": 543624,
    //  "name": "Kotovo",
    //  "cod": 200
    //}
}

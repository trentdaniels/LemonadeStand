using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {
        // Members
        private int temperature;
        private List<string> possibleForecasts;
        private string forecast;

        public string Forecast
        {
            get
            {
                return forecast;
            }
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
        }
        public List<string> PossibleForecasts
        {
            get
            {
                return possibleForecasts;
            }
        }

        // Constructors
        public Weather(Random random)
        {
            possibleForecasts = new List<string>() { "sunny", "rainy", "cloudy", "clear" };
            forecast = possibleForecasts[random.Next(0, possibleForecasts.Count)];
            temperature = random.Next(50, 100);
        }

        // Methods
    }
}

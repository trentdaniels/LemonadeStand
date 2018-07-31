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
        private int forecastedLow;
        private int forecastedHigh;

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
        public int ForecastedLow 
        {
            get => forecastedLow;
        }
        public int ForecastedHigh
        {
            get => forecastedHigh;
        }

        // Constructors
        public Weather(Random random)
        {
            possibleForecasts = new List<string>() { "sunny", "rainy", "cloudy", "clear" };
            forecast = possibleForecasts[random.Next(0, possibleForecasts.Count)];
            forecastedLow = random.Next(50, 75);
            forecastedHigh = random.Next(75, 100);
            temperature = random.Next(forecastedLow, forecastedHigh);

        }

        // Methods
    }
}

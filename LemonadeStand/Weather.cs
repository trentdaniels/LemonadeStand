using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {
        // Members
        private int temperature;
        private List<string> possibleForecasts;

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
            temperature = random.Next(50, 100);
        }

        // Methods
    }
}

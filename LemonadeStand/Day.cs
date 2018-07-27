using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day
    {
        // Members
        private Weather weather;
        private int dayNumber;

        public int DayNumber
        {
            get
            {
                return dayNumber;
            }
        }
        public Weather Weather
        {
            get
            {
                return weather;
            }
        }

        // Constructor
        public Day(Random random)
        {
            weather = new Weather(random);
            dayNumber = 1;
        }

        // Methods
        public int GetTemperature() 
        {
            return weather.Temperature;
        }
        public string GetWeatherForecast(List<string> forecasts, Random randomIndex)
        {
            return forecasts[randomIndex.Next(0, forecasts.Count)];
        }
    }
}

﻿using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {
        // Members
        private int temperature;
        private List<string> possibleForecasts;
        private string weatherType;
        private int forecastedLow;
        private int forecastedHigh;
        private string forecastedWeatherType;
        private WeatherAPI weatherAPI;


        public WeatherAPI WeatherAPI { get => weatherAPI; }
        public string WeatherType
        {
            get => weatherType;
            set => weatherType = value;
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
        public string ForecastedWeatherType
        {
            get => forecastedWeatherType;
        }

        // Constructors
        public Weather(Random random)
        {
            weatherAPI = new WeatherAPI();
            possibleForecasts = new List<string>() { "sunny", "rainy", "cloudy", "clear" };
            forecastedWeatherType = possibleForecasts[random.Next(0, possibleForecasts.Count)];
            forecastedLow = WeatherAPI.ApiForecastedLow;
            forecastedHigh = WeatherAPI.ApiForecastedHigh;
            temperature = random.Next(forecastedLow, forecastedHigh);
            HandleWeather(random);

        }

        // Methods
        public bool WillWeatherComeTrue (Random random)
        {
            int chanceOfCorrectWeather;

            chanceOfCorrectWeather = random.Next(0, 2);
            switch (chanceOfCorrectWeather)
            {
                case 0:
                    return true;
                default:
                    return false;
            }
        }
        public void HandleWeather(Random random)
        {
            if(!WillWeatherComeTrue(random))
            {
                
                WeatherType = possibleForecasts[random.Next(0, possibleForecasts.Count)];
                return;
            }
            if (WeatherAPI.ApiForecast.ToLower().Contains("shower") || WeatherAPI.ApiForecast.ToLower().Contains("storm"))
            {
                WeatherType = "rainy";
                return;
            }
            if (WeatherAPI.ApiForecast.ToLower().Contains("sun"))
            {
                WeatherType = "sunny";
                return;
            }
            if (WeatherAPI.ApiForecast.ToLower().Contains("cloud"))
            {
                WeatherType = "cloudy";
                return;
            }
            WeatherType = "clear";
        }
    }
}

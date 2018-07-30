using System;
namespace LemonadeStand
{
    public class Customer
    {
        // Members
        private int chanceToBuy;

        public int ChanceToBuy
        {
            get
            {
                return chanceToBuy;
            }
            set
            {
                chanceToBuy = value;
            }
        }

        // Constructor
        public Customer()
        {
        }

        // Methods
        public void BuyLemonade(Player player, Random random, Day day) 
        {
            player.Inventory.Cup.Amount--;
            player.Inventory.Lemon.Amount -= player.Recipe.LemonsPerCup;
            player.Inventory.Ice.Amount -= player.Recipe.IcePerCup;
            player.Inventory.Sugar.Amount -= player.Recipe.SugarPerCup;
        }
        //public bool WillBuy (Random random, Day day) 
        //{
        //    int temperaturePoints;
        //    int bonusPoints;
        //    int totalPoints;
        //    int forecastPoints;
        //    int recipePoints;

        //    totalPoints = 100;
        //    bonusPoints = random.Next(0, 6);
        //    temperaturePoints = DetermineTemperatureDeductible(day, random);
        //    // temperature, recipes, and forecast point total are each a MAX 30 POINTS!!!
        //}
        private int DetermineTemperatureDeductible(Day day, Random random)
        {
            int temperatureDeductible;

            if (day.Weather.Temperature > 85)
            {
                temperatureDeductible = random.Next(0, 10);
            }
            else if (day.Weather.Temperature > 65)
            {
                temperatureDeductible = random.Next(10, 22);
            }
            else {
                temperatureDeductible = random.Next(20, 30);
            }
            return temperatureDeductible;
        }

        private int DetermineForecastDeductible (Day day, Random random)
        {
            int forecastDeductible;

            switch(day.Weather.Forecast)
            {
                case "sunny":
                    forecastDeductible = random.Next(0, 8);
                    return forecastDeductible;
                case "clear":
                    forecastDeductible = random.Next(8, 15);
                    return forecastDeductible;
                case "cloudy":
                    forecastDeductible = random.Next(15, 23);
                    return forecastDeductible;
                case "rainy":
                    forecastDeductible = random.Next(20, 30);
                    return forecastDeductible;
            }

        }

    }
}

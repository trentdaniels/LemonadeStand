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
        public void BuyLemonade(Random random, Day day, Player player) 
        {
            if (WillBuy(random, day, player) && player.Inventory.Cup.Amount > 0)
            {
                player.Inventory.Cup.Amount--;
                player.Inventory.Lemon.Amount -= player.Recipe.LemonsPerCup;
                player.Inventory.Ice.Amount -= player.Recipe.IcePerCup;
                player.Inventory.Sugar.Amount -= player.Recipe.SugarPerCup;
                player.Inventory.AvailableMoney += player.PriceOfLemonade;
                day.BuyingCustomers++;
                player.Inventory.TotalGain += player.PriceOfLemonade;
            }

        }
        public bool WillBuy (Random random, Day day, Player player) 
        {
            int temperatureDeductible;
            int bonusDeductible;
            int forecastDeductible;
            int recipeDeductible;
            int priceDeductible;

            ChanceToBuy = 100;
            bonusDeductible = random.Next(0, 6);
            temperatureDeductible = DetermineTemperatureDeductible(random, day);
            forecastDeductible = DetermineForecastDeductible(random, day);
            recipeDeductible = DetermineRecipeDeductible(random, day, player);
            priceDeductible = DeterminePriceDeductible(random, day, player);

            ChanceToBuy -= temperatureDeductible + forecastDeductible + recipeDeductible + priceDeductible + bonusDeductible;
            if (ChanceToBuy < 55)
            {
                return false;
            }
            return true;



        //    // temperature, recipes, and forecast point total are each a MAX 30 POINTS!!!
        }
        private int DetermineTemperatureDeductible(Random random, Day day)
        {
            int temperatureDeductible;

            if (day.Weather.Temperature > 85)
            {
                temperatureDeductible = random.Next(0, 10);
            }
            else if (day.Weather.Temperature > 65)
            {
                temperatureDeductible = random.Next(10, 18);
            }
            else {
                temperatureDeductible = random.Next(18, 22);
            }
            return temperatureDeductible;
        }

        private int DetermineForecastDeductible (Random random, Day day)
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
                default:
                    forecastDeductible = random.Next(20, 26);
                    return forecastDeductible;
                
            }

        }
        private int DetermineRecipeDeductible (Random random, Day day, Player player)
        {
            int recipeDeductible;

            if (day.Weather.Forecast == "sunny" && player.Recipe.IcePerCup > player.Recipe.LemonsPerCup && player.Recipe.SugarPerCup < player.Recipe.IcePerCup)
            {
                recipeDeductible = random.Next(0, 10);
            }
            else if (day.Weather.Forecast == "clear" && player.Recipe.IcePerCup == player.Recipe.LemonsPerCup && player.Recipe.IcePerCup == player.Recipe.SugarPerCup)
            {
                recipeDeductible = random.Next(0, 10);
            }
            else if (day.Weather.Forecast == "cloudy" && player.Recipe.LemonsPerCup > player.Recipe.IcePerCup && player.Recipe.LemonsPerCup > player.Recipe.SugarPerCup)
            {
                recipeDeductible = random.Next(0, 10);
            }
            else if (day.Weather.Forecast == "rainy" && player.Recipe.SugarPerCup > player.Recipe.IcePerCup && player.Recipe.SugarPerCup > player.Recipe.LemonsPerCup)
            {
                recipeDeductible = random.Next(0, 10);
            }
            else
            {
                recipeDeductible = random.Next(10, 21);
            }
            return recipeDeductible;
        }

        private int DeterminePriceDeductible(Random random, Day day, Player player)
        {
            int priceDeductible;

            if (day.Weather.Temperature > 85 && player.PriceOfLemonade > .28)
            {
                priceDeductible = random.Next(0, 6);
            }
            else if (day.Weather.Temperature > 65 && player.PriceOfLemonade > .23 && player.PriceOfLemonade <= .27)
            {
                priceDeductible = random.Next(0, 6);
            }
            else if (day.Weather.Temperature > 50 && player.PriceOfLemonade > .20 && player.PriceOfLemonade <= .24)
            {
                priceDeductible = random.Next(0, 6);
            }
            else if (player.PriceOfLemonade > .35)
            {
                priceDeductible = random.Next(15, 26);
            }
                
            else 
            {
                priceDeductible = random.Next(5, 12);
            }
            return priceDeductible;
        }
    }
}

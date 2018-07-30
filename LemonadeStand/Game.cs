using System;
namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Player player;
        //private Customer customer; 
        private Day day;
        public Random random;
        private int daysOfGameplay;

        // Costructor
        public Game()
        {
            random = new Random();
            SetUpGame();
            RunGame();

        }

        // Methods
        private void SetUpGame() 
        {
            player = new Player();
            DisplayWelcomeMessage();
            daysOfGameplay = GetDaysToPlay();

        }

        private void RunGame()
        {
            day = new Day(random);
            DisplayWeather(day, day.Weather);
            DisplayInventory(player.Inventory);
            RunStore();
            RunRecipe();

        }
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Welcome to Lemonade Stand {player.Name}!");
        }

        private void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine($"You have {inventory.Cup.Amount} cups, {inventory.Lemon.Amount} lemons, {inventory.Sugar.Amount} cups of sugar, and {inventory.Ice.Amount} ice cubes.");
        }



        private void DisplayWeather(Day today, Weather weather)
        {
            int temperature = today.GetTemperature();
            string forecast = today.GetWeatherForecast(weather.PossibleForecasts, random);
            Console.WriteLine($"Day {today.DayNumber}'s weather is {temperature} degrees and {forecast}.");
        }
        private int GetDaysToPlay ()
        {
            string daysOptions;
            int gameplayDays;

            Console.WriteLine("How many days would you like to play?\n[1]7 Days\n[2]14 Days\n[3]30 Days");
            daysOptions = Console.ReadLine();
            switch (daysOptions)
            {
                case "1":
                    gameplayDays = 7;
                    return gameplayDays;
                case "2":
                    gameplayDays = 14;
                    return gameplayDays;
                case "3":
                    gameplayDays = 30;
                    return gameplayDays;
                default:
                    Console.Write("Invalid option. Please try again.");
                    return GetDaysToPlay();
            }

        }
        private void IncrementDay () 
        {
            day.DayNumber++;
        }
        private void RunStore() 
        {
            int updatedCups = player.BuyFood(player.Inventory.Cup);
            int updatedLemons = player.BuyFood(player.Inventory.Lemon);
            int updatedSugar = player.BuyFood(player.Inventory.Sugar);
            int updatedIce = player.BuyFood(player.Inventory.Ice);
            Console.WriteLine($"You now have:\n{player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}\n{player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}\n{player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}\n{player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}\n");
        }
        private void RunRecipe()
        {
            player.HandleRecipeChange();
            player.SetPriceOfLemonade();
        }
    }
}

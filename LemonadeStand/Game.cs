using System;
namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Player player;
        //private Customer customer; 
        private Day day;
        private Store store;
        public Random random;
        private int daysOfGameplay;

        // Costructor
        public Game()
        {
            random = new Random();
            store = new Store();
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
            player.SetPriceOfLemonade();
            RunStore();

        }
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Welcome to Lemonade Stand {player.Name}!");
        }

        private void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine($"You have {inventory.AmountOfCups} cups, {inventory.AmountOfLemons} lemons, {inventory.AmountOfSugar} cups of sugar, and {inventory.AmountOfCups} ice cubes.");
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
            int updatedCups = player.BuyCups(store);
            int updatedLemons = player.BuyLemons(store);
            int updatedSugar = player.BuySugar(store);
            int updatedIce = player.BuyIce(store);
            Console.WriteLine($"You bought {updatedCups} cups. You have {player.Inventory.AvailableMoney} left!");
        }
    }
}

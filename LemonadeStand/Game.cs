using System;
namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Player player;
        //private Customer customer; 
        private Day day;
        //private Store store;
        public Random random;

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
            DisplayInventory(player.Inventory);
            player.SetPriceOfLemonade();
        }

        private void RunGame()
        {
            day = new Day(random);
            DisplayWeather(day, day.Weather);
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
    }
}

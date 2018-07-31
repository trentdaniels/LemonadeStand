using System;
namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Player player;
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
            DisplayWeather(day);
            DisplayInventory(player.Inventory);
            RunStore();
            RunRecipe();
            RunDay();
            DisplayDayResults();
            IncrementDay();

        }
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Welcome to Lemonade Stand {player.Name}!");
        }

        private void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine($"You have {inventory.Cup.Amount} {inventory.Cup.Name}, {inventory.Lemon.Amount} {inventory.Lemon.Name}, {inventory.Sugar.Amount} {inventory.Sugar.Name}, and {inventory.Ice.Amount} {inventory.Ice.Name}.");
        }



        private void DisplayWeather(Day today)
        {
            int temperature = today.Weather.Temperature;
            string forecast = today.Weather.Forecast;
            Console.WriteLine($"Day {today.DayNumber}'s weather is {temperature} degrees and {forecast}.");
            today.CreateCustomers(random);
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
            player.Recipe.HandleRecipeChange();
            player.SetPriceOfLemonade();
        }
        private void DisplayDayResults() 
        {
            Console.WriteLine($"At the end of the day, you now have {player.Inventory.AvailableMoney}.");
            Console.WriteLine($"You also have:\n{player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}\n{player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}\n{player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}\n{player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}");

        }
        private void RunDay()
        {
            Console.WriteLine("Let the day begin!");
            foreach(Customer customer in day.Customers)
            {
                customer.BuyLemonade(random, day, player);
                if(CheckForSellout())
                {
                    break;
                }


            }

        }
        private bool CheckForSellout()
        {
            if (player.Inventory.Cup.Amount < 0)
            {
                Console.WriteLine($"Sold out of {player.Inventory.Cup.Name}..");
                player.Inventory.Cup.Amount = 0;
                return true;
            }
            if (player.Inventory.Lemon.Amount < 0)
            {
                Console.WriteLine($"Sold out of {player.Inventory.Lemon.Name}..");
                player.Inventory.Lemon.Amount = 0;
                return true;
            }
            if (player.Inventory.Sugar.Amount < 0)
            {
                Console.WriteLine($"Sold out of {player.Inventory.Sugar.Name}..");
                player.Inventory.Sugar.Amount = 0;
                return true;
            }
            if (player.Inventory.Ice.Amount < 0)
            {
                Console.WriteLine($"Sold out of {player.Inventory.Ice.Name}..");
                player.Inventory.Ice.Amount = 0;
                return true;
            }
            return false;
        }
    }
}

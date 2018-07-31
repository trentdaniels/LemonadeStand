using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Day day;
        public Random random;
        private int daysOfGameplay;
        public List<Player> players;

        // Costructor
        public Game()
        {
            random = new Random();
            players = UserInterface.CreatePlayers();

        }

        // Methods
        public void SetUpGame()
        {
            foreach(Player player in players)
            {
                player.Name = player.GetName(players, player);
            }
            UserInterface.DisplayWelcomeMessage(players);
            daysOfGameplay = GetDaysToPlay();
            UserInterface.DisplayTotalGameDays(daysOfGameplay);

        }

        public void RunGame()
        {
            
            for (int i = 1; i <= daysOfGameplay; i++)
            {
                day = new Day(random);
                day.DayNumber = i;
                UserInterface.DisplayWeather(day);
                day.CreateCustomers(random);
                foreach (Player player in players)
                {
                    UserInterface.DisplayInventory(player);
                    RunStore();
                    RunRecipe();
                    RunDay();
                    UserInterface.DisplayDayResults(player, day);
                    player.Inventory.BeginningDayMoney = player.Inventory.AvailableMoney;
                }
            }



        }



        private int GetDaysToPlay()
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
                    UserInterface.DisplayErrorMessage();
                    return GetDaysToPlay();
            }

        }
        private void RunStore()
        {
            foreach(Player player in players)
            {
                if (NeedsSupplies(player))
                {
                    int updatedCups = player.BuyFood(player.Inventory.Cup);
                    int updatedLemons = player.BuyFood(player.Inventory.Lemon);
                    int updatedSugar = player.BuyFood(player.Inventory.Sugar);
                    int updatedIce = player.BuyFood(player.Inventory.Ice);
                }
                UserInterface.DisplayNewInventory(player);
            }

        }
        private bool NeedsSupplies(Player player)
        {
            string needsSuppliesInput;
            Console.WriteLine($"Do you want to go to the store {player.Name}? [1]Yes or [2]No");
            needsSuppliesInput = Console.ReadLine();
            switch (needsSuppliesInput)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    UserInterface.DisplayErrorMessage();
                    return NeedsSupplies(player);
            }

        }
        private void RunRecipe()
        {
            foreach(Player player in players)
            {
                player.Recipe.HandleRecipeChange(player);
                player.SetPriceOfLemonade();
            }

        }

        private void RunDay()
        {
            foreach (Player player in players)
            {
                Console.WriteLine("Let the day begin!");
                foreach (Customer customer in day.Customers)
                {
                    customer.BuyLemonade(random, day, player);
                    bool soldOutCups = CheckForSellout(player.Inventory.Cup);
                    bool soldOutLemons = CheckForSellout(player.Inventory.Lemon);
                    bool soldOutSugar = CheckForSellout(player.Inventory.Sugar);
                    bool soldOutIce = CheckForSellout(player.Inventory.Ice);
                    if (soldOutCups || soldOutLemons || soldOutSugar || soldOutIce)
                    {
                        break;
                    }
                }
            }


        }
        private bool CheckForSellout(Item item)
        {
            if (item.Amount < 0)
            {
                Console.WriteLine($"Sold out of {item.Name}..");
                item.Amount = 0;
                return true;
            }

            return false;
        }

        public void RunEndGame()
        {
            foreach(Player player in players)
            {
                UserInterface.DisplayFinalResults(player);

            }
            UserInterface.DetermineWinner(players);

        }
        public bool PlayAgain()
        {
            string playAgain;
            Console.WriteLine("Would you like to play again? [1]Yes or [2]No");
            playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "1":
                    Console.WriteLine("Let's start a new game.");
                    return true;
                case "2":
                    Console.WriteLine("Thanks for playing!");
                    return false;
                default:
                    UserInterface.DisplayErrorMessage();
                    return PlayAgain();
            }
        }

    }
}

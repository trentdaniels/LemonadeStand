using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Player
    {
        // Members
        private Inventory inventory;
        private string name;
        private double priceOfLemonade;
        private Recipe recipe;


        public double PriceOfLemonade
        {
            set
            {
                priceOfLemonade = value;
            }
            get
            {
                return priceOfLemonade;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Inventory Inventory
        {
            get
            {
                return inventory;
            }

        }
        public Recipe Recipe
        {
            get
            {
                return recipe;
            }
        }



        // Constructor
        public Player()
        {
            
            inventory = new Inventory();
            priceOfLemonade = .25;
            recipe = new Recipe();
        }

        // Methods


        public string GetName(List<Player> players, Player player)
        {
            string playerName;

            Console.WriteLine($"What is your name Player {players.IndexOf(player) + 1}?");
            playerName = Console.ReadLine();

            if (playerName.Length < 1)
            {
                UserInterface.DisplayErrorMessage();
                return GetName(players, player);
            }
            return playerName;
        
        }

        public void SetPriceOfLemonade()
        {
            bool changePrice = WantsToChangePrice();
            if (changePrice)
            {
                PriceOfLemonade = double.Parse(Console.ReadLine());
                Console.WriteLine($"Lemonade is now ${PriceOfLemonade}.");
            }


        }
        private bool WantsToChangePrice()
        {
            string changePriceInput;
            Console.WriteLine($"The price for your lemonade is ${PriceOfLemonade}.");
            Console.WriteLine("Do you want to change the price? [1]Yes or [2]No");
            changePriceInput= Console.ReadLine();

            switch (changePriceInput)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    UserInterface.DisplayErrorMessage();
                    return WantsToChangePrice();
            }
        }

        public int BuyFood(Item item)
        {
            int amountToBuy;

            Console.WriteLine($"You have {item.Amount} {item.Name} and ${inventory.AvailableMoney} available.");
            Console.WriteLine($"How many {item.Name} would you like to buy (${item.Price} each)?");
            amountToBuy = int.Parse(Console.ReadLine());
            if (!AbleToBuy(amountToBuy, item.Price))
            {
                return BuyFood(item);
            }
            if (amountToBuy < 0)
            {
                UserInterface.DisplayErrorMessage();
                return BuyFood(item);
            }
            item.Amount += amountToBuy;
            inventory.AvailableMoney -= amountToBuy * item.Price;
            inventory.TotalLoss += amountToBuy * item.Price;

            Console.WriteLine($"You now have {item.Amount} {item.Name}!");
            return amountToBuy;
            // Used item as a parameter with the expectation of passing in a more specific child class as the argument. 
            // This illustrates the liskov substitution principle that a child class should be used the same as the parent

        }

        public bool AbleToBuy(int amountOfFood, double price)
        {
            if (amountOfFood * price > inventory.AvailableMoney)
            {
                Console.WriteLine("Cannot buy this many due to lack of funds");
                return false;
            }
            return true;
            // Single responsibility in this function. It simply tells the user whether or not they can buy a certain amount of an item
        }

    }

}


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
            name = GetName();
            inventory = new Inventory();
            priceOfLemonade = .25;
            recipe = new Recipe();
        }

        // Methods


        public string GetName()
        {
            string playerName;

            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();

            if (playerName.Length < 1)
            {
                Console.WriteLine("Invalid name. Please enter something next time!");
                return GetName();
            }
            return playerName;

        }

        public void SetPriceOfLemonade()
        {
            Console.WriteLine($"How much would you like your lemonade to cost? It currently costs ${PriceOfLemonade}");
            PriceOfLemonade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Lemonade is now ${PriceOfLemonade}.");

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
                Console.WriteLine("Invalid input. Please choose a non-negative amount to buy");
                return BuyFood(item);
            }
            item.Amount += amountToBuy;
            inventory.AvailableMoney -= amountToBuy * item.Price;

            Console.WriteLine($"You now have {item.Amount} {item.Name}!");
            return amountToBuy;


        }

        public bool AbleToBuy(int amountOfFood, double price)
        {
            if (amountOfFood * price > inventory.AvailableMoney)
            {
                Console.WriteLine("Cannot buy this many due to lack of funds");
                return false;
            }
            return true;
        }
        public void HandleRecipeChange() 
        {
            string changeRecipe;
            Console.WriteLine($"Your current recipe (per pitcher) is:\nCups: {recipe.CupsPerPitcher}\nLemons: {recipe.LemonsPerPitcher}\nCups of Sugar: {recipe.SugarPerPitcher}\nIce Cubes: {recipe.IcePerPitcher}");
            Console.WriteLine("Would you like to change the recipe? [1]Yes or [2]No");
            changeRecipe = Console.ReadLine();

            switch(changeRecipe)
            {
                case "1":
                    SetRecipeItem();
                    Console.WriteLine($"New recipe is:\nCups: {recipe.CupsPerPitcher}\nLemons: {recipe.LemonsPerPitcher}\nCups of Sugar: {recipe.SugarPerPitcher}\nIce Cubes: {recipe.IcePerPitcher}");
                    break;
                case "2":
                    Console.WriteLine("Recipe will be kept the same!");
                    break;
                default:
                    Console.WriteLine("Invalid input please choose [1]Yes or [2]No");
                    HandleRecipeChange();
                    return;
            }


        }
        public void SetRecipeItem()
        {
            Console.WriteLine("How many cups do you want to use?");
            recipe.CupsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many lemons do you want to use?");
            recipe.LemonsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar do you want to use?");
            recipe.SugarPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes do you want to use?");
            recipe.IcePerPitcher = int.Parse(Console.ReadLine());
        }
    }

}


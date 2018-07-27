using System;
namespace LemonadeStand
{
    public class Player
    {
        // Members
        //private Inventory inventory;
        private double amountOfMoney;
        private string name;
        private double priceOfLemonade;

        public double PriceOfLemonade {
            set 
            {
                priceOfLemonade = value;
            }
            get 
            {
                return priceOfLemonade;
            }
        }
        public string Name {
            get {
                return name;
            }
        }

        // Constructor
        public Player()
        {
            name = GetName();
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
    }
}

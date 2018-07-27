using System;
namespace LemonadeStand
{
    public class Player
    {
        // Members
        //private Inventory inventory;
        private double availableMoney;
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
        public double AvailableMoney
        {
            get {
                return availableMoney;
            }
            set {
                availableMoney = value;
            }
        }
        // Constructor
        public Player()
        {
            name = GetName();
            AvailableMoney = 20;
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

using System;
namespace LemonadeStand
{
    public class Player
    {
        // Members
        private Inventory inventory;
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


        // Constructor
        public Player()
        {
            name = GetName();
            inventory = new Inventory();
            priceOfLemonade = .25;
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

        public void SetPriceOfLemonade ()
        {
            Console.WriteLine("How much would you like your lemonade to cost?");
            PriceOfLemonade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Lemonade is now ${PriceOfLemonade}.");
               
        }
    }
}

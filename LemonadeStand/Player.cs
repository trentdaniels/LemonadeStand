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
        public int BuyCups(Store store) 
        {
            int amountToBuy;

            Console.WriteLine($"You have {inventory.AmountOfCups} cups and ${inventory.AvailableMoney} available.");
            Console.WriteLine($"How many cups ({store.CupPrice} per cup) would you like to purchase?");
            amountToBuy = int.Parse(Console.ReadLine());
            if (!AbleToBuy(amountToBuy, store.CupPrice))
            {
                return BuyCups(store);
            }
            inventory.AmountOfCups += amountToBuy;
            inventory.AvailableMoney -= amountToBuy * store.CupPrice;

            return amountToBuy;


        }
        public void CalculateTransaction() 
        {
            
        }
        public bool AbleToBuy( int amountOfFood, double price)
        {
            if (amountOfFood * price > inventory.AvailableMoney)
            {
                Console.WriteLine("Cannot buy this many due to lack of funds");
                return false;
            }
            return true;
        }
    }
}

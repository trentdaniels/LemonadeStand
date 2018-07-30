using System;
namespace LemonadeStand
{
    public class Customer
    {
        // Members
        private int chanceToBuy;

        public int ChanceToBuy
        {
            get
            {
                return chanceToBuy;
            }
            set
            {
                chanceToBuy = value;
            }
        }

        // Constructor
        public Customer()
        {
        }

        // Methods
        public void BuyLemonade(Player player) 
        {
            // When customer buys food, decrease Player cups by 1. CupCount can be the name
            // Create another function that checks if customer will buy
            // Keep track of how many cups get bought
            // If cups bought equals recipe cups, then decrease player inventory counts for all other ingredients by the recipe count
        }
        private bool WillCustomerBuy(Weather)
        {
            
        }


    }
}

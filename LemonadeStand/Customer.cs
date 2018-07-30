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
            player.Inventory.Cup.Amount--;
            player.Inventory.Lemon.Amount -= player.Recipe.LemonsPerCup;
            player.Inventory.Ice.Amount -= player.Recipe.IcePerCup;
            player.Inventory.Sugar.Amount -= player.Recipe.SugarPerCup;
        }



    }
}

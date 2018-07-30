using System;
namespace LemonadeStand
{
    public abstract class Item
    {
        
        protected int  amount;
        protected string name;
        protected double price;

        public int Amount 
        {
            get 
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }

        public Item()
        {
                
        }
    }
}

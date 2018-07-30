using System;
namespace LemonadeStand
{
    public class Inventory
    {
        // Members
        private Cup cup;
        private Lemon lemon;
        private Sugar sugar;
        private Ice ice;
        private double availableMoney;

        public Cup Cup
        {
            get
            {
                return cup;
            }
        }
        public Lemon Lemon
        {
            get
            {
                return lemon;
            }
           
        }
        public Sugar Sugar
        {
            get
            {
                return sugar;
            }
        }
        public Ice Ice
        {
            get
            {
                return ice;
            }
        }
        public double AvailableMoney
        {
            get
            {
                return availableMoney;
            }
            set
            {
                availableMoney = value;
            }
        }


        // Constructors
        public Inventory()
        {
            ice = new Ice();
            lemon = new Lemon();
            sugar = new Sugar();
            cup = new Cup();
            availableMoney = 20;
            Console.WriteLine("Initialized Inventory");
        }

        // Methods
    }
}

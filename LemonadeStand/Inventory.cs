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
        private int pitchers;

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
        public int Pitchers
        {
            get
            {
                return pitchers;
            }
            set
            {
                pitchers = value;
            }
        }


        // Constructors
        public Inventory()
        {
            ice = new Ice();
            lemon = new Lemon();
            sugar = new Sugar();
            cup = new Cup();
            availableMoney = 20.00;
            Console.WriteLine("Initialized Inventory");
        }

        // Methods

    }
}

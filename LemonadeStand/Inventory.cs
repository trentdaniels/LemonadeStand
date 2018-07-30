using System;
namespace LemonadeStand
{
    public class Inventory
    {
        // Members
        private Cups cups;
        private Lemons lemons;
        private Sugar sugar;
        private Ice ice;
        private double availableMoney;

        public Cups Cups
        {
            get
            {
                return cups;
            }
        }
        public Lemons Lemons
        {
            get
            {
                return lemons;
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
            lemons = new Lemons();
            sugar = new Sugar();
            cups = new Cups();
            availableMoney = 20;
            Console.WriteLine("Initialized Inventory");
        }

        // Methods
    }
}

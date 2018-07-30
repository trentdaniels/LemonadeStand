using System;
namespace LemonadeStand
{
    public class Store
    {
        // Members
        private Cups cups;
        private Lemons lemons;
        private Sugar sugar;
        private Ice ice;

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



        // Constructors
        public Store()
        {
            cups = new Cups();
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new Ice();
            Console.WriteLine("Initialized Store.");
        }

        // Methods
    }
}

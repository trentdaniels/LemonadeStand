using System;
namespace LemonadeStand
{
    public class Inventory
    {
        // Members
        private double amountOfCups;
        private double amountOfLemons;
        private double amountOfSugar;
        private double amountOfIce;
        private double availableMoney;

        public double AmountOfCups
        {
            get
            {
                return amountOfCups;
            }
            set
            {
                amountOfCups = value;
            }
        }
        public double AmountOfLemons
        {
            get
            {
                return amountOfLemons;
            }
            set
            {
                amountOfLemons = value;
            }
        }
        public double AmountOfSugar
        {
            get
            {
                return amountOfSugar;
            }
            set
            {
                amountOfSugar = value;
            }
        }
        public double AmountOfIce
        {
            get
            {
                return amountOfIce;
            }
            set
            {
                amountOfIce = value;
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
            amountOfCups = 0;
            amountOfLemons = 0;
            amountOfSugar = 0;
            amountOfIce = 0;
            availableMoney = 20;
            Console.WriteLine("Initialized Inventory");
        }

        // Methods
    }
}

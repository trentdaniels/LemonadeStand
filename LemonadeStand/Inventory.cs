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
        private double beginningMoney;
        private double totalGain;
        private double totalLoss;
        private double beginningDayMoney;

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
        public double BeginningMoney
        {
            get
            {
                return beginningMoney;
            }

        }
        public double BeginningDayMoney
        {
            get
            {
                return beginningDayMoney;
            }
            set
            {
                beginningDayMoney = value;
            }
        }

        public double TotalGain
        {
            get
            {
                return totalGain;
            }
            set
            {
                totalGain = value;
            }
        }
        public double TotalLoss
        {
            get
            {
                return totalLoss;
            }
            set
            {
                totalLoss = value;
            }
        }


        // Constructors
        public Inventory()
        {
            ice = new Ice();
            lemon = new Lemon();
            sugar = new Sugar();
            cup = new Cup();
            beginningMoney = 20.00;
            availableMoney = beginningMoney;
            beginningDayMoney = availableMoney;
        }

        // Methods

    }
}

using System;
namespace LemonadeStand
{
    public class Store
    {
        // Members
        private double cupPrice;
        private double lemonPrice;
        private double sugarPrice;
        private double icePrice;

        public double CupPrice
        {
            get
            {
                return cupPrice;
            }
        }
        public double LemonPrice
        {
            get
            {
                return lemonPrice;
            }
        }
        public double SugarPrice
        {
            get
            {
                return sugarPrice;
            }
        }
        public double IcePrice
        {
            get
            {
                return icePrice;
            }
        }

        // Constructors
        public Store()
        {
        }

        // Methods
    }
}

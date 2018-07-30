using System;
namespace LemonadeStand
{
    public class Recipe
    {
        // Members
        private int cupsPerPitcher;
        private int lemonsPerPitcher;
        private int sugarPerPitcher;
        private int icePerPitcher;

        public int CupsPerPitcher
        {
            get
            {
                return cupsPerPitcher;
            }
            set
            {
                cupsPerPitcher = value;
            }
        }
        public int LemonsPerPitcher
        {
            get
            {
                return lemonsPerPitcher;
            }
            set
            {
                lemonsPerPitcher = value;
            }
        }
        public int SugarPerPitcher
        {
            get
            {
                return sugarPerPitcher;
            }
            set
            {
                sugarPerPitcher = value;
            }
        }
        public int IcePerPitcher
        {
            get
            {
                return icePerPitcher;
            }
            set
            {
                icePerPitcher = value;

            }
        }

        // Constructors
        public Recipe()
        {
            cupsPerPitcher = 4;
            lemonsPerPitcher = 4;
            sugarPerPitcher = 4;
            icePerPitcher = 4;
            
        }

        // Methods
    }
}

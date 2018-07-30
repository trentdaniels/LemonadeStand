using System;
namespace LemonadeStand
{
    public class Recipe
    {
        // Members
        private int lemonsPerCup;
        private int sugarPerCup;
        private int icePerCup;


        public int LemonsPerCup
        {
            get
            {
                return lemonsPerCup;
            }
            set
            {
                lemonsPerCup = value;
            }
        }
        public int SugarPerCup
        {
            get
            {
                return sugarPerCup;
            }
            set
            {
                sugarPerCup = value;
            }
        }
        public int IcePerCup
        {
            get
            {
                return icePerCup;
            }
            set
            {
                icePerCup = value;

            }
        }

        // Constructors
        public Recipe()
        {
            lemonsPerCup = 4;
            sugarPerCup = 4;
            icePerCup = 4;
            
        }

        // Methods
        public void HandleRecipeChange()
        {
            string changeRecipe;
            Console.WriteLine($"Your current recipe (per cup) is:\nLemons: {LemonsPerCup}\nCups of Sugar: {SugarPerCup}\nIce Cubes: {IcePerCup}");
            Console.WriteLine("Would you like to change the recipe? [1]Yes or [2]No");
            changeRecipe = Console.ReadLine();

            switch (changeRecipe)
            {
                case "1":
                    SetRecipeItem();
                    Console.WriteLine($"New recipe is:\nLemons: {LemonsPerCup}\nCups of Sugar: {SugarPerCup}\nIce Cubes: {IcePerCup}");
                    break;
                case "2":
                    Console.WriteLine("Recipe will be kept the same!");
                    break;
                default:
                    Console.WriteLine("Invalid input please choose [1]Yes or [2]No");
                    HandleRecipeChange();
                    return;
            }


        }
        public void SetRecipeItem()
        {
            Console.WriteLine("How many lemons do you want to use?");
            LemonsPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar do you want to use?");
            SugarPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes do you want to use?");
            IcePerCup = int.Parse(Console.ReadLine());
        }
    }
}

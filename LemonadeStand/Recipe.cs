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
            lemonsPerCup = 2;
            sugarPerCup = 2;
            icePerCup = 2;
            
        }

        // Methods
        public void HandleRecipeChange(Player player)
        {
            string changeRecipe;
            Console.WriteLine($"{player.Name}, your current recipe (per cup) is:\nLemons: {LemonsPerCup}\nCups of Sugar: {SugarPerCup}\nIce Cubes: {IcePerCup}");
            Console.WriteLine("Would you like to change the recipe? [1]Yes or [2]No");
            changeRecipe = Console.ReadLine();

            switch (changeRecipe)
            {
                case "1":
                    SetRecipeItem(player.Inventory.Lemon, player.Inventory.Sugar, player.Inventory.Ice);
                    Console.WriteLine($"Your new recipe is:\nLemons: {LemonsPerCup}\nCups of Sugar: {SugarPerCup}\nIce Cubes: {IcePerCup}");
                    break;
                case "2":
                    Console.WriteLine("Your recipe will be kept the same!");
                    break;
                default:
                    UserInterface.DisplayErrorMessage();
                    HandleRecipeChange(player);
                    return;
            }


        }
        public void SetRecipeItem(Lemon lemon, Sugar sugar, Ice ice)
        {
            Console.WriteLine($"How many {lemon.Name} do you want to use?");
            LemonsPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many {sugar.Name} do you want to use?");
            SugarPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many {ice.Name} do you want to use?");
            IcePerCup = int.Parse(Console.ReadLine());
        }
    }
}

using System;
namespace LemonadeStand
{
    public class Game
    {
        // Members
        private Player player;
        //private Customer customer; 
        //private Day day;
        //private Store store;

        // Costructor
        public Game()
        {
            SetUpGame();
            RunGame();
        }

        // Methods
        private void SetUpGame() 
        {
            player = new Player();
            DisplayWelcomeMessage();
        }

        private void RunGame()
        {
            
        }
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Welcome to Lemonade Stand {player.Name}!");
        }
    }
}

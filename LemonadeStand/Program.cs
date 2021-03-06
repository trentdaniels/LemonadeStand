﻿using System;

namespace LemonadeStand
{
    class MainClass
    {
        public static void Main()
        {
            
            Game game = new Game();
            bool playAgain;
            do
            {
                game.SetUpGame();
                game.RunGame();
                game.RunEndGame();

                playAgain = game.PlayAgain();
            }
            while (playAgain);
        }
    }
}

using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayErrorMessage()
        {
            Console.WriteLine("Invalid input. Please try again.");
            // single responsibility- This function simply displays an error message.
        }
        public static void DisplayFinalResults(Player player)
        {
            double netProfit = player.Inventory.AvailableMoney - player.Inventory.BeginningMoney;
            string positiveNegative = netProfit > 0 ? "+" : "-";
            Console.WriteLine($"{player.Name} began with ${player.Inventory.AvailableMoney}, and you now have ${player.Inventory.AvailableMoney}.");
            Console.WriteLine($"{player.Name} had a total gain of ${player.Inventory.TotalGain} and a total loss of {player.Inventory.TotalLoss}.");
            Console.WriteLine($"{player.Name}'s net profit is {netProfit} for a {positiveNegative}{player.Inventory.AvailableMoney / player.Inventory.BeginningMoney}% change.");
        }
        public static void DisplayDayResults(Player player, Day day)
        {
            Console.WriteLine($"At the end of day {day.DayNumber}, {player.Name} now has ${player.Inventory.AvailableMoney} from your original ${player.Inventory.BeginningDayMoney}.");
            Console.WriteLine($"Your net profit for the day is ${Math.Round(player.Inventory.AvailableMoney - player.Inventory.BeginningDayMoney, 2)}");
            Console.WriteLine($"{player.Name} also has:\n{player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}\n{player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}\n{player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}\n{player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}");
            Console.WriteLine($"{day.BuyingCustomers} out of {day.Customers.Count} customers bought your lemonade.");
        }
        public static void DisplayWelcomeMessage(List<Player>players)
        {
            if (players.Count > 1)
            {
                Console.WriteLine($"Welcome to Lemonade Stand {players[0].Name} and {players[1].Name}!");
            }
            else
            {
                Console.WriteLine($"Welcome to Lemonade Stand {players[0].Name}!");
            }

        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine($"{player.Name} has {player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}, {player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}, {player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}, and {player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}.");
        }
        public static void DisplayNewInventory(Player player)
        {
            Console.WriteLine($"{player.Name} now has:\n{player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}\n{player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}\n{player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}\n{player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}");
        }
        public static void DisplayWeather(Day day)
        {
            int temperature = day.Weather.Temperature;
            string weatherType = day.Weather.WeatherType;
            Console.WriteLine($"Day {day.DayNumber}'s actual weather is {temperature} degrees and {weatherType}.");
        }

        public static List<Player> CreatePlayers()
        {
            List<Player> players;
            string userInput;

            players = new List<Player>() { };
            Console.WriteLine("Are you playing with [1]1 Player or [2]2 Players?");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    players.Add(new Player());
                    return players;
                case "2":
                    players.Add(new Player());
                    players.Add(new Player());
                    return players;
                default:
                    DisplayErrorMessage();
                    return CreatePlayers();
            }
        }
        public static void DetermineWinner(List<Player> players) 
        {
            Player player1;
            Player player2;

            if (players.Count > 1)
            {
                player1 = players[0];
                player2 = players[1];

                if (player1.Inventory.AvailableMoney > player2.Inventory.AvailableMoney)
                {
                    Console.WriteLine($"{player1.Name} WINS!!!");
                }
                else
                {
                    Console.WriteLine($"{player2.Name} WINS!!!");
                }
            }
        }
        public static void DisplayTotalGameDays(int gameDays)
        {
            Console.WriteLine($"The game will be run for a total of {gameDays} days.");
        }
        public static void DisplayForecast(Day day)
        {
            Console.WriteLine($"Day {day.DayNumber}'s forecast is a high of {day.Weather.ForecastedHigh} degrees and low of {day.Weather.ForecastedLow} degrees. It looks {day.Weather.ForecastedWeatherType}.");
        }
    }
}

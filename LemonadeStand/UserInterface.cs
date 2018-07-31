using System;
namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayErrorMessage()
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
        public static void DisplayFinalResults(Player player)
        {
            double netProfit = player.Inventory.AvailableMoney - player.Inventory.BeginningMoney;
            string positiveNegative = netProfit > 0 ? "+" : "-";
            Console.WriteLine($"You began with ${player.Inventory.AvailableMoney}, and you now have ${player.Inventory.AvailableMoney}.");
            Console.WriteLine($"You had a total gain of ${player.Inventory.TotalGain} and a total loss of {player.Inventory.TotalLoss}.");
            Console.WriteLine($"Your net profit is {netProfit} for a {positiveNegative}{player.Inventory.AvailableMoney / player.Inventory.BeginningMoney}% change.");
        }
        public static void DisplayDayResults(Player player, Day day)
        {
            Console.WriteLine($"At the end of {day.DayNumber}, you now have ${player.Inventory.AvailableMoney} from your original {player.Inventory.BeginningDayMoney}.");
            Console.WriteLine($"You also have:\n{player.Inventory.Cup.Amount} {player.Inventory.Cup.Name}\n{player.Inventory.Lemon.Amount} {player.Inventory.Lemon.Name}\n{player.Inventory.Sugar.Amount} {player.Inventory.Sugar.Name}\n{player.Inventory.Ice.Amount} {player.Inventory.Ice.Name}");
            Console.WriteLine($"{day.BuyingCustomers} out of {day.Customers.Count} customers bought your lemonade.");
        }
        public static void DisplayWelcomeMessage( Player player )
        {
            Console.WriteLine($"Welcome to Lemonade Stand {player.Name}!");
        }
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine($"You have {inventory.Cup.Amount} {inventory.Cup.Name}, {inventory.Lemon.Amount} {inventory.Lemon.Name}, {inventory.Sugar.Amount} {inventory.Sugar.Name}, and {inventory.Ice.Amount} {inventory.Ice.Name}.");
        }
        public static void DisplayWeather(Day day)
        {
            int temperature = day.Weather.Temperature;
            string forecast = day.Weather.Forecast;
            Console.WriteLine($"Day {day.DayNumber}'s weather is {temperature} degrees and {forecast}.");
        }
    }
}

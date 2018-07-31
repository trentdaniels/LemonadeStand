using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day
    {
        // Members
        private Weather weather;
        private int dayNumber;
        private List<Customer> customers;
        private int buyingCustomers;

        public int DayNumber
        {
            get
            {
                return dayNumber;
            }
            set
            {
                dayNumber = value;
            }
        }
        public Weather Weather
        {
            get
            {
                return weather;
            }
        }
        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
        }
        public int BuyingCustomers
        {
            get
            {
                return buyingCustomers;
            }
            set
            {
                buyingCustomers = value;
            }
        }

        // Constructor
        public Day(Random random)
        {
            weather = new Weather(random);
            buyingCustomers = 0;
        }

        // Methods

        public void CreateCustomers(Random random)
        {
            customers = new List<Customer>() { };
            for (int i = 0; i < Weather.Temperature + random.Next(0,20); i++)
            {
                customers.Add(new Customer());

            }
            Console.WriteLine($"There are a possible {customers.Count} customers coming today!");
        }
         
    }
}

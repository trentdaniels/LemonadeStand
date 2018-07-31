using System;
namespace LemonadeStand
{
    public class Cup: Item
    {
        
        public Cup()
        {
            price = .03;
            name = "cups";
            amount = 0;
            // Using the Parent class's fields upon instantiating within the child class constructor
            // This illustraties liskov's substitution pricinciple that a child class should be used the same as it's parent class
                    
        }
    }
}

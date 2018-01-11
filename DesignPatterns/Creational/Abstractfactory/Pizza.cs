using System;
using System.Collections.Generic;


namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class Pizza
    {
        private List<string> toppings;
        public Pizza(params string[] toppings)
        {
            this.toppings = new List<string>();
            this.toppings.AddRange(toppings);
        }
        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }
        public IEnumerable<string> Toppings
        {
            get
            {
                return toppings;
            }
        }
        public virtual void Cook()
        {
            Console.WriteLine("standard cooking");
        }
        public virtual void Slice()
        {
            Console.WriteLine("standard slicing");
        }
        public abstract void Prepare();

    }
}

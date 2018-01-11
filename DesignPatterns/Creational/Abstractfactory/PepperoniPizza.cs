using System;


namespace DesignPatterns.Creational.AbstractFactory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base("cheese", "tomato",
            "pepperoni")
        { }
        public override void Prepare()
        {
            Console.WriteLine("No it's not peperoni,it's actually salame");
        }
    }
}

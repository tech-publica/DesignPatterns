
using System;


namespace DesignPatterns.Creational.AbstractFactory
{
    public class Capricciosa : Pizza
    {
        public Capricciosa() : base("mozzarella", "tomato sauce",
            "black olives", "ham", "mushrooms", "artichokes" )
        { }
        public override void Prepare()
        {
            Console.WriteLine("preparing a fancy capricciosa");
        }
    }
}

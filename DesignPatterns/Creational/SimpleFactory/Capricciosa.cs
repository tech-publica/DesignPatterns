
using System;


namespace DesignPatterns.Creational.SimpleFactory
{
    public class Capricciosa : Pizza
    {
        public Capricciosa() : base("mozzarella", "pomodoro",
            "olive nere", "prosciutto cotto", "carciofini" )
        { }
        public override void Prepare()
        {
            Console.WriteLine("preparing a fancy capricciosa");
        }
    }
}

using System;


namespace DesignPatterns.Creational.AbstractFactory
{
    public class FettuccineAlfredo : Pasta
    {
        public FettuccineAlfredo()
            : base("burro and (probably fake) parmigiano", false)
        { }

        public override void Cook()
        {
            Console.WriteLine("cooking not so italian fettuccine...");
        }
    }
}

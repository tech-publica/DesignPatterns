using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ArancinoPalermitano : Arancino
    {
        public void Taste()
        {
            Console.WriteLine("I am a very tasty arancino palermo style");
        }
    }
}

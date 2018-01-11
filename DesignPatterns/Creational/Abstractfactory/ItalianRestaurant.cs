using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Creational.Abstractfactory
{
    public class ItalianRestaurant : Restaurant
    {
        public override Pasta CookPasta() => new Ravioli();


        public override Pizza CookPizza() => new Capricciosa();
        
    }
}

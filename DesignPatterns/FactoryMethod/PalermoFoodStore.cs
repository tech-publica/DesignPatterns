using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class PalermoFoodStore : FoodStore
    {
        public override Arancino CookArancino() => new ArancinoPalermitano();
        
    }
}

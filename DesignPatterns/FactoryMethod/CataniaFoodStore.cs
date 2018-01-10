using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class CataniaFoodStore : FoodStore
    {
        public override Arancino CookArancino() => new ArancinoCatanese();
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class FoodStore
    {
        public void ReceiveOrder(int howMany) { /*logic to receive order */ }

        public void ShipOrder() { /*logic to ship order */ }

        //note how this is abstract
        public abstract Arancino CookArancino();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class FoodStore
    {
        public void ReceiveOrder(int howMany)
        { }

        public void ShipOrder()
        { }

        public abstract Arancino CookArancino();


    }
}

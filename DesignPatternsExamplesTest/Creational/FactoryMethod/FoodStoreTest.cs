using DesignPatterns.Creational.FactoryMethod;
using System;
using Xunit;

namespace DesignPatternsExamplesTest.Creational.FactoryMethod
{
    public class FoodStoreTest
    {
        [Fact]
        public void CookArancinoCatanese()
        {
            FoodStore store = new CataniaFoodStore();
            store.ReceiveOrder(1);
            Arancino cino = store.CookArancino();
            store.ShipOrder();
            Assert.IsType<ArancinoCatanese>(cino);
        }

        [Fact]
        public void CookArancinoPalermitano()
        {
            FoodStore store = new PalermoFoodStore();
            store.ReceiveOrder(1);
            Arancino cino = store.CookArancino();
            store.ShipOrder();
            Assert.IsType<ArancinoPalermitano>(cino);
        }
    }
}

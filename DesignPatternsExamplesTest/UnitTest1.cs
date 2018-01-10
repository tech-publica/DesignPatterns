using DesignPatterns.FactoryMethod;
using System;
using Xunit;

namespace DesignPatternsExamplesTest
{
    public class FoodStoreTest
    {
        [Fact]
        public void CookArancinoCatanese()
        {
            FoodStore store = new CataniaFoodStore();
            Arancino cino = store.CookArancino();
            Assert.IsType<ArancinoCatanese>(cino);
        }

        [Fact]
        public void CookArancinoPalermitano()
        {
            FoodStore store = new PalermoFoodStore();
            Arancino cino = store.CookArancino();
            Assert.IsType<ArancinoPalermitano>(cino);
        }
    }
}

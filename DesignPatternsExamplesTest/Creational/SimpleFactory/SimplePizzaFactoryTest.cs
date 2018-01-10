using DesignPatterns.Creational.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsExamplesTest.Creational.SimpleFactory
{
    public class SimplePizzaFactoryTest
    {
        [Fact]
        public void CreatePizza()
        {
            Pizza pizza = SimplePizzaFactory.CreatePizza(PizzaType.capricciosa);
            Assert.IsType<Capricciosa>(pizza);

            pizza = SimplePizzaFactory.CreatePizza(PizzaType.margherita);
            Assert.IsType<Margherita>(pizza);
        }
    }
}

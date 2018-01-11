using DesignPatterns.Creational.Abstractfactory;
using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsExamplesTest.Creational.AbstractFactory
{

    public class RestaurantTest
    {
        [Fact]
        public void CookPizza()
        {
            Restaurant resto = Restaurant.Instance;
            Pizza pizza = resto.CookPizza();
            Assert.IsType<Capricciosa>(pizza);
        }

        [Fact]
        public void CookPasta()
        {
            Restaurant resto = Restaurant.Instance;
            Pasta pasta = resto.CookPasta();
            Assert.IsType<Ravioli>(pasta);


        }
    }
}

using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstractfactory
{
    public abstract class Restaurant
    {
        public abstract Pizza CookPizza();
        public abstract Pasta CookPasta();

        public static Restaurant Instance
        {
            get
            {
                foreach(Type t in typeof(Restaurant).Assembly.GetTypes())
                {
                    if( !t.IsInterface && typeof(Restaurant).IsAssignableFrom(t))
                    {
                        return (Restaurant) Activator.CreateInstance(t);
                    }
                }
                return null;
            }
        }
    }
}

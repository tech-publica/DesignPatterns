using System;

namespace DesignPatterns.Creational.Singleton
{
    //there can be only one :)
    public class Highlander
    {
        private static Lazy<Highlander> instance = 
            new Lazy<Highlander>(() => new Highlander(), true);

        public static Highlander Instance
        {
            get
            {           
                return instance.Value;
            }
        }
        private Highlander()
        {

        }

        public static void ShowSpecialEffects()
        {

        }

        public void SaveTheWorld()
        {

        }
    }
}

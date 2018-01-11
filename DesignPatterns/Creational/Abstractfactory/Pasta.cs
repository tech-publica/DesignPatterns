

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class Pasta
    {
        public Pasta(string condiment, bool isFresh)
        {
            Condiment = condiment;
            Fresh = isFresh;
        }
        public string Condiment { get; }
        public bool Fresh { get;}
        public abstract void Cook();
    }
}

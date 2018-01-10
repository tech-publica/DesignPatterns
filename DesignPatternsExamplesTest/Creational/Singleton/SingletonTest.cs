using DesignPatterns.Creational.Singleton;
using Xunit;

namespace DesignPatternsExamplesTest.Creational.Singleton
{
    public class SingletonTest
    {
        [Fact]
        public void RequestSingletonTest()
        {
            Highlander connor = Highlander.Instance;
            Highlander another = Highlander.Instance;
            Assert.Same(connor, another);
        }
    }
}

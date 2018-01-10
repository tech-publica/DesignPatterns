using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Hardware;
using Xunit;

namespace DesignPatternsExamplesTest.Creational.Builder
{
    public class HardwareBuilderTest
    {
        [Fact]
        public void BuildDesktop()
        {
            DesktopBuilder builder = new DesktopBuilder();
            HardwareDirector director = new HardwareDirector(builder);
            director.Assemble();
            Desktop desk = builder.Build();
            Assert.Equal(300, desk.components.HD);
            Assert.Equal(16, desk.components.RAM);

        }

        [Fact]
        public void BuildGameConsole()
        {
            GameConsoleBuilder builder = new GameConsoleBuilder();
            HardwareDirector director = new HardwareDirector(builder);
            director.Assemble();
            GameConsole console = builder.Build();
            Assert.Equal(300, console.components.HD);
            Assert.Equal(16, console.components.RAM);
        }
    }
}

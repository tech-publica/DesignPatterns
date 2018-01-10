using DesignPatterns.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class GameConsoleBuilder : HardwareBuilder
    {

        private GameConsole console = new GameConsole();

        public HardwareBuilder AddHD(int giga)
        {
            console.components.HD = giga;
            return this;
        }

        public HardwareBuilder AddRam(int giga)
        {
            console.components.RAM = giga;
            return this;
        }

        public HardwareBuilder AddSSD(int giga)
        {
            console.components.SSD = giga;
            return this;
        }

        public GameConsole Build()
        {
            return console;
        }
    }
}


using DesignPatterns.Creational.Builder.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class DesktopBuilder : HardwareBuilder
    {

        private Desktop desktop = new Desktop();

        public HardwareBuilder AddHD(int giga)
        {
            desktop.components.HD = giga;
            return this;
        }

        public HardwareBuilder AddRam(int giga)
        {
            desktop.components.RAM = giga;
            return this;
        }

        public HardwareBuilder AddSSD(int giga)
        {
            desktop.components.SSD = giga;
            return this;
        }

        public Desktop Build()
        {
            return desktop;
        }
    }
}

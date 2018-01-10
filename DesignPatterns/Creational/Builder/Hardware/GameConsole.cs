using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.Hardware
{
    public class GameConsole
    {
        public HardwareComponents components { get; set; } = new HardwareComponents();
    }
}

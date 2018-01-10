using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public interface HardwareBuilder
    {
        HardwareBuilder AddRam(int giga);
        HardwareBuilder AddSSD(int giga);
        HardwareBuilder AddHD(int giga);


    }


}

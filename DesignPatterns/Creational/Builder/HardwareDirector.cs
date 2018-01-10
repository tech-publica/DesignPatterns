using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class HardwareDirector
    {
        private HardwareBuilder builder;
        public HardwareDirector(HardwareBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(HardwareBuilder builder)
        {
            this.builder = builder;
        }

        public void Assemble()
        {
            builder.AddHD(300)
                    .AddRam(16);

        }

    }
}

using DesignPatterns.Builder;
using DesignPatterns.Builder.Adventurer;
using DesignPatterns.Hardware;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //DesktopBuilder builder = new DesktopBuilder();
            //HardwareDirector director = new HardwareDirector(builder);
            //director.Assemble();
            //Desktop desk = builder.Build();

            //GameConsoleBuilder gbild = new GameConsoleBuilder();
            //director.ChangeBuilder(gbild);

            //director.Assemble();

            //GameConsole console = gbild.Build();

            Adventurer dink = Adventurer.Create
                                        .WithName("Dink Smallwood")
                                        .WithSex(Sex.male)
                                        .WithHP(100)
                                        .Stats
                                        .Assign(a => a.Stats.Intelligence, 80)
                                        .Assign(a => a.Stats.Strength, 70)
                                        .Build();




            Console.WriteLine("Hello World!");
        }
    }
}

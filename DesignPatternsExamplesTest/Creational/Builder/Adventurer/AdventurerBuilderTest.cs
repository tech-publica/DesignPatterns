using System;
using Xunit;
using DesignPatterns.Creational.Builder.FacetedBuilder;

namespace DesignPatternsExamplesTest.Creational.Builder.FacetedBuilder
{
    public class AdventurerBuilderTest
    {
        [Fact]
        public void CreateAdventurer()
        {
            Adventurer dink = Adventurer.Create
                                      .WithName("Dink Smallwood")
                                      .WithSex(Sex.male)
                                      .WithHP(100)
                                      .Stats
                                      .Assign(a => a.Stats.Intelligence, 80)
                                      .Assign(a => a.Stats.Strength, 70)
                                      .Build();

            Assert.Equal("Dink Smallwood", dink.Name);
            Assert.Equal(Sex.male, dink.Sex);
            Assert.Equal(100, dink.HitPoints);
            Assert.Equal(80, dink.Stats.Intelligence);
            Assert.Equal(70, dink.Stats.Strength);
        }

    }
}

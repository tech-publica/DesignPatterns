using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Builder.Adventurer
{
    public enum Sex { male, female, undecided}

    public class Adventurer
    {
        private Adventurer() { }
        public Stats Stats { get; set; } = new Stats();
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public Sex Sex { get; set; }


        public static AdventurerBuilder Create => new AdventurerBuilderImpl();

        private class AdventurerBuilderImpl : AdventurerBuilder
        {
            protected Adventurer adventurer = new Adventurer();

            public AdventurerStatsBuilder Stats => new AdventurerStatsBuilderImpl(adventurer);

            public Adventurer Build()
            {
                return adventurer;
            }

            public AdventurerBuilder WithHP(int hp)
            {
                adventurer.HitPoints = hp;
                return this;
            }

            public AdventurerBuilder WithName(string name)
            {
                adventurer.Name = name;
                return this;
            }

            public AdventurerBuilder WithSex(Sex sex)
            {
                adventurer.Sex = sex;
                return this;
            }


        }

        private class AdventurerStatsBuilderImpl : AdventurerBuilderImpl, AdventurerStatsBuilder
        {
            public AdventurerStatsBuilderImpl(Adventurer adventurer)
            {
                this.adventurer = adventurer;
            }

            public AdventurerStatsBuilder Assign<TProp>(Expression<Func<Adventurer, TProp>> statSelector, int value)
            {
                PropertyInfo property = ((MemberExpression)statSelector.Body).Member as PropertyInfo;
                property.SetValue(adventurer.Stats, value);
                return this;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatterns.Creational.Builder.FacetedBuilder
{
    public interface AdventurerStatsBuilder : AdventurerBuilder
    {
        AdventurerStatsBuilder Assign<TProp>(Expression<Func<Adventurer, TProp>> statSelector, int value);
    }
}

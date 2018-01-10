using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatterns.Builder.Adventurer
{
    public interface AdventurerStatsBuilder : AdventurerBuilder
    {
        AdventurerStatsBuilder Assign<TProp>(Expression<Func<Adventurer, TProp>> statSelector, int value);
    }
}

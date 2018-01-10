using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Adventurer
{
    public interface AdventurerBuilder
    {
        AdventurerBuilder WithName(string name);
        AdventurerBuilder WithSex(Sex sex);
        AdventurerBuilder WithHP(int hp);
        AdventurerStatsBuilder Stats { get; }
        Adventurer Build();
        
    }
}

using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Strategy.NoStrategy;

using Xunit;
namespace DesignPatternsExamplesTest.Behavioral.Strategy
{
    public class AggressivePlayerTest
    {
        [Fact]
        public void AggressivePlayerAttack()
        {
           PadelPlayer player = new AggressivePadelPlayer();
           PlayResult attackResult = player.Attack();
           Assert.Equal(Style.AGGRESSIVE, attackResult.Style);
        }
        [Fact]
        public void AggressivePlayerDefend()
        {
            PadelPlayer player = new AggressivePadelPlayer();
            PlayResult defendResult = player.Defend();
            Assert.Equal(Style.AGGRESSIVE, defendResult.Style);
        }
    }

}
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Strategy.NoStrategy;
using Xunit;
namespace DesignPatternsExamplesTest.Behavioral.Strategy
{
    public class ManouveringPlayerTest
    {
        [Fact]
        public void ManouveringPlayerAttack()
        {
            PadelPlayer player = new ManouveringPadelPlayer();
            PlayResult attackResult = player.Attack();
            Assert.Equal(Style.CAREFUL, attackResult.Style);
        }
        [Fact]
        public void AggressivePlayerDefend()
        {
            PadelPlayer player = new ManouveringPadelPlayer();
            PlayResult defendResult = player.Defend();
            Assert.Equal(Style.CAREFUL, defendResult.Style);
        }
    }

}
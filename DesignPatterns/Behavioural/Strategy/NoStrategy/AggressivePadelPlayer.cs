using System;
namespace DesignPatterns.Behavioural.Strategy.NoStrategy
{
    public class AggressivePadelPlayer : PadelPlayer
    {
        public override PlayResult Attack()
        {
            Console.WriteLine("Attacking recklessly!");
            Luck luck = new Luck();
            if (luck.IsFavorable)
            {
                return new PlayResult(ShotQuality.WINNER, Style.AGGRESSIVE);
            }
            if (luck.IsAverage)
            {
                return new PlayResult(ShotQuality.STRONG, Style.AGGRESSIVE);
            }
            return new PlayResult(ShotQuality.ERROR, Style.AGGRESSIVE);
        }

        public override PlayResult Defend()
        {
            Console.WriteLine("Defending recklessly!");
            Luck luck = new Luck();
            if (luck.IsVeryFavorable)
            {
                return new PlayResult(ShotQuality.WINNER, Style.AGGRESSIVE);
            }
            if (luck.IsFavorable)
            {
                return new PlayResult(ShotQuality.STRONG, Style.AGGRESSIVE);
            }
            if (luck.IsAverage)
            {
                return new PlayResult(ShotQuality.WEAK, Style.AGGRESSIVE);
            }
            return new PlayResult(ShotQuality.ERROR, Style.AGGRESSIVE);
        }
    }
}
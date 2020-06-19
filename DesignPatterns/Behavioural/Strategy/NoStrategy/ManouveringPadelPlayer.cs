using System;

namespace DesignPatterns.Behavioural.Strategy.NoStrategy
{
    public class ManouveringPadelPlayer : PadelPlayer
    {
        public override PlayResult Attack()
        {
            Console.WriteLine("Attacking with strategy!");
            Luck luck = new Luck();
            if (luck.IsVeryFavorable)
            {
                return new PlayResult(ShotQuality.WINNER, Style.CAREFUL);
            }
            if (luck.IsRoutine)
            {
                return new PlayResult(ShotQuality.STRONG, Style.CAREFUL);
            }
            return new PlayResult(ShotQuality.ERROR, Style.CAREFUL); ;
        }

        public override PlayResult Defend()
        {
            Console.WriteLine("Defending with strategy!");
            Luck luck = new Luck();
            if (luck.IsReasonable)
            {
                return new PlayResult(ShotQuality.STRONG, Style.CAREFUL);
            }
            if (luck.IsRoutine)
            {
                return new PlayResult(ShotQuality.WEAK, Style.CAREFUL);
            }
            return new PlayResult(ShotQuality.ERROR, Style.CAREFUL);
        }
    }
}
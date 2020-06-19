using System;
namespace DesignPatterns.Behavioural.Strategy
{
    public class Luck
    {
        private Random random = new Random();
        private int result;
        private int min = 1;
        private int upperBound = 101;
        public Luck()
        {
            Try();
        }
        public void Try()
        {
            result = random.Next(min, upperBound);
        }
        public bool IsVeryFavorable
        {
            get => result > 90;
        }
        public bool IsFavorable
        {
            get => result > 70;
        }
        public bool IsAverage
        {
            get => result > 50;
        }
        public bool IsReasonable
        {
            get => result > 30;
        }
        public bool IsRoutine
        {
            get => result > 10;
        }
    }
}
using System;
namespace DesignPatterns.Behavioural.Strategy.NoStrategy
{
    public abstract class PadelPlayer
    {
        public abstract PlayResult Defend();
        public abstract PlayResult Attack();

    }
}
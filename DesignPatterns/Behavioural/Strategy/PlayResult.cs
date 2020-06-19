namespace DesignPatterns.Behavioural.Strategy
{
    public class PlayResult
    {
        public PlayResult(ShotQuality quality, Style style)
        {
            Quality = quality;
            Style = style;
        }
        public ShotQuality Quality { get; }
        public Style Style { get; }
    }
}
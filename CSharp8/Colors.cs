namespace CSharp8
{
    public enum Color
    {
        Red,
        Blue,
        Yellow,
        Purple,
        Orange,
        Unknown
    }

    public static class TuplePatternDemo
    {
        public static Color MixColor(Color color1, Color color2)
        {
            return (color1, color2) switch
            {
                (Color.Red, Color.Blue) => Color.Purple,
                (Color.Blue, Color.Red) => Color.Purple,
                (Color.Yellow, Color.Red) => Color.Orange,
                (Color.Red, Color.Yellow) => Color.Orange,
                (_, _) when color1 == color2 => color1,
                _ => Color.Unknown
            };
        }
    }
}
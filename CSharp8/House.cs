namespace CSharp8
{
    public class House
    {
        public string Name { get; set; }

        public int Floors { get; set; }
    }

    public static class PropertyPatternDemo
    {
        public static bool IsTenFloorsHighAndNamedSkyscraper(House house)
        {
            return house is { Floors: 10, Name: "Skyscraper" };
        }
    }
}

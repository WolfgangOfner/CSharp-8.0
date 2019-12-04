using System;
using System.Linq;

namespace CSharp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NullableReferencyTypes();

            //PatternMatching();

            //IndicesAndRange();
        }

        private static void IndicesAndRange()
        {
            var numbers = Enumerable.Range(1, 10).ToArray();
            var copy = numbers[..];
            var allButFirst = numbers[1..];
            var lastItemRange = numbers[^1..];
            var lastItem = numbers[^1];
            var lastThree = numbers[^3..];

            Console.WriteLine($"numbers: {string.Join(", ",numbers)}");
            Console.WriteLine($"copy: {string.Join(", ", copy)}");
            Console.WriteLine($"allButFirst: {string.Join(", ", allButFirst)}");
            Console.WriteLine($"lastItemRange: {string.Join(", ", lastItemRange)}");
            Console.WriteLine($"lastItem {lastItem}");
            Console.WriteLine($"lastThree: {string.Join(", ", lastThree)}");
        }

        public static void PatternMatching()
        {
            PropertyPattern();
            SwitchExpression();
            TuplePattern();
        }

        private static void TuplePattern()
        {
            Console.WriteLine(TuplePatternDemo.MixColor(Color.Red, Color.Blue));
        }

        private static void SwitchExpression()
        {
            Console.WriteLine(SwtichExpressionDemo.DisplayShapeInformation(new Circle(12)));
        }

        public static void PropertyPattern()
        {
            var house = new House { Floors = 10, Name = "Skyscraper" };
            Console.WriteLine(PropertyPatternDemo.IsTenFloorsHighAndNamedSkyscraper(house));
        }

        public static void NullableReferencyTypes()
        {
            var car = new Car();

            Console.WriteLine($"The make of the car has {car.Make.Length} characters");

            // tell the compile that car.Make can never be null (which is not true in this case)
            //Console.WriteLine($"The make of the car has {car.Make!.Length} characters");
        }
    }
}
namespace CSharp8
{
    public class Triangle
    {
        public Triangle(int sideLength)
        {
            SideLength = sideLength;
        }

        public int SideLength { get; set; }
    }

    public class Rectangle
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get; set; }

        public int Width { get; set; }
    }

    public class Circle
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }
    }

    public static class SwtichExpressionDemo
    {
        public static string DisplayShapeInformation(object geometricObject)
        {
            return geometricObject switch
            {
                Triangle triangle => $"Triangle with a side length of {triangle.SideLength}",
                Rectangle rectangle => rectangle switch
                {
                    _ when rectangle.Length == rectangle.Width => "This is a square",
                    _ => $"Rectangle with a length of {rectangle.Length} and width of {rectangle.Width}",
                },
                Circle circle => $"Circle with a radius of {circle.Radius}",
                _ => "Unknown geometric object"
            };
        }
    }
}

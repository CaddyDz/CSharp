using System;

namespace CSharpTutA
{
    class Rectangle : Shape
    {
        public double Length { set; get; }

        public double Width { set; get; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and a Width of {Width}");
        }
    }
}

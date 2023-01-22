using System;

namespace Shapes.FirstTask
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(float a, float b) : base(a, b, b) { }

        public override void CountArea()
        {
            Console.WriteLine($"Площадь: {a * b} см2");
        }
    }
}
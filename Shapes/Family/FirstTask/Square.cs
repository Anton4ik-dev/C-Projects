using System;

namespace Shapes.FirstTask
{
    public class Square : Rectangle
    {
        public Square(float a) : base(a, a) { }

        public override void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {4 * a} см");
        }

        public override void CountArea()
        {
            Console.WriteLine($"Площадь: {a * a} см2");
        }
    }
}
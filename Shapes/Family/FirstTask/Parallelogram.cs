using System;

namespace Shapes.FirstTask
{
    public class Parallelogram : Tetragon
    {
        private float h;

        public Parallelogram(float a, float b, float h) : base(a, b, h, h)
        {
            this.h = h;
        }

        public override void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {2*(a + b)} см");
        }

        public override void CountArea()
        {
            Console.WriteLine($"Площадь: {a*h} см2");
        }
    }
}
using System;

namespace Shapes.SecondTask
{
    public class Parallelogram : ICountPerimetrArea
    {
        private float a;
        private float b;
        private float h;

        public Parallelogram(float a, float b, float h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {2 * (a + b)} см");
        }

        public void CountArea()
        {
            Console.WriteLine($"Площадь: {a * h} см2");
        }
    }
}
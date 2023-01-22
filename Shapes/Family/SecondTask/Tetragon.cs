using System;

namespace Shapes.SecondTask
{
    public class Tetragon : ICountPerimetrArea
    {
        private float a;
        private float b;
        private float c;
        private float d;

        public Tetragon(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {a + b + c + d} см");
        }

        public void CountArea()
        {
            float p = (a + b + c + d) / 2;
            Console.WriteLine($"Площадь: {Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d))} см2");
        }
    }
}
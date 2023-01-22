using System;

namespace Shapes.FirstTask
{
    public class Tetragon
    {
        public float a;
        public float b;
        private float c;
        private float d;

        public Tetragon(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public virtual void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {a+b+c+d} см");
        }

        public virtual void CountArea()
        {
            float p = (a + b + c + d) / 2;
            Console.WriteLine($"Площадь: {Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d))} см2");
        }
    }
}
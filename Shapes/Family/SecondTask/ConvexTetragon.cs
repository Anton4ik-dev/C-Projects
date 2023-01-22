using System;

namespace Shapes.SecondTask
{
    public class ConvexTetragon : ICountPerimetrArea
    {
        private float a;
        private float b;
        private float c;
        private float d;
        private float d1;
        private float d2;
        private float angle;

        public ConvexTetragon(float a, float b, float c, float d, float d1, float d2, float angle)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.d1 = d1;
            this.d2 = d2;
            this.angle = angle;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {a + b + c + d} см");
        }

        public void CountArea()
        {
            Console.WriteLine($"Площадь: {0.5f * d1 * d2 * Math.Sin(angle)} см2");
        }
    }
}
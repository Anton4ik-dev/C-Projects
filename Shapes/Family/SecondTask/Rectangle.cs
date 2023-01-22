using System;

namespace Shapes.SecondTask
{
    public class Rectangle : ICountPerimetrArea
    {
        private float a;
        private float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {2 * (a + b)} см");
        }

        public void CountArea()
        {
            Console.WriteLine($"Площадь: {a * b} см2");
        }
    }
}
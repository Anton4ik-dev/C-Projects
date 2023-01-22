using System;

namespace Shapes.SecondTask
{
    public class Square : ICountPerimetrArea
    {
        private float a;

        public Square(float a)
        {
            this.a = a;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {4 * a} см");
        }

        public void CountArea()
        {
            Console.WriteLine($"Площадь: {a * a} см2");
        }
    }
}
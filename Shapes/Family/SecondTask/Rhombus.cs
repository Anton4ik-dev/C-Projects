using System;

namespace Shapes.SecondTask
{
    public class Rhombus : ICountPerimetrArea
    {
        private float d1;
        private float d2;
        private float a;

        public Rhombus(float d1, float d2, float a)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.a = a;
        }

        public void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {4 * a} см");
        }

        public void CountArea()
        {
            Console.WriteLine($"Площадь: {(d1 * d2) / 2} см2");
        }
    }
}
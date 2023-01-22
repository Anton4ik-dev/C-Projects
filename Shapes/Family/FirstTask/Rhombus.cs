using System;

namespace Shapes.FirstTask
{
    public class Rhombus : Parallelogram
    {
        private float c;

        public Rhombus(float d1, float d2, float c) : base(d1, d2, c)
        {
            this.c = c;
        }

        public override void CountPerimeter()
        {
            Console.WriteLine($"Периметр: {4 * c} см");
        }

        public override void CountArea()
        {
            Console.WriteLine($"Площадь: {(a * b) / 2} см2");
        }
    }
}
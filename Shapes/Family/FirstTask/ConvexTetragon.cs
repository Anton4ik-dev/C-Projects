using System;

namespace Shapes.FirstTask
{
    public class ConvexTetragon : Tetragon
    {
        private float d1;
        private float d2;
        private float angle;

        public ConvexTetragon(float a, float b, float c, float d, float d1, float d2, float angle) : base(a, b, c, d)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.angle = angle;
        }

        public override void CountArea()
        {
            Console.WriteLine($"Площадь: {0.5f * d1 * d2 * Math.Sin(angle)} см2");
        }
    }
}
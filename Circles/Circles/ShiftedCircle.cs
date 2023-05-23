using System;

namespace Circles
{
    class ShiftedCircle : Circle
    {
        private double _x;
        private float _y;

        public void SetShift(double x, float y)
        {
            _x = x;
            _y = y;
        }

        public override void Draw()
        {
            int radius = 5;
            double console_ratio = 2.0f;
            double a = console_ratio * radius;
            double b = radius;

            for (float y = -radius - _y; y <= radius + _y; y++)
            {
                for (double x = -a - _x; x <= a + _x; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);
                    if (d > 0.99 && d < 1.2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
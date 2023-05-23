using System;

namespace Circles
{
    class DecoratorCircle : Circle
    {
        public override void Draw()
        {
            int radius = 5;
            double console_ratio = 4f;
            double a = console_ratio * radius;
            double b = radius;

            for (float y = -radius - 50; y <= radius + 50; y++)
            {
                for (double x = -a - 50; x <= a + 50; x++)
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
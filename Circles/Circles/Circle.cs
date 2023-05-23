using System;

namespace Circles
{
    public class Circle
    {
        public virtual void Draw()
        {
            int radius = 5;
            double console_ratio = 2.5f;
            double a = console_ratio * radius;
            double b = radius;

            for (float y = -radius; y <= radius; y++)
            {
                for (double x = -a; x <= a; x++)
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
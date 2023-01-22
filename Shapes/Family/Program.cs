using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask.Tetragon a = new FirstTask.Tetragon(2, 4, 5, 6);
            a.CountPerimeter();
            a.CountArea();
            FirstTask.ConvexTetragon b = new FirstTask.ConvexTetragon(2, 4, 5, 6, 7, 7, 2);
            b.CountPerimeter();
            b.CountArea();
            FirstTask.Parallelogram c = new FirstTask.Parallelogram(2, 4, 5);
            c.CountPerimeter();
            c.CountArea();
            FirstTask.Rhombus d = new FirstTask.Rhombus(2, 4, 5);
            d.CountPerimeter();
            d.CountArea();
            FirstTask.Rectangle e = new FirstTask.Rectangle(2, 4);
            e.CountPerimeter();
            e.CountArea();
            FirstTask.Square t = new FirstTask.Square(2);
            t.CountPerimeter();
            t.CountArea();

            Console.WriteLine("---------------------------------");

            SecondTask.Tetragon y = new SecondTask.Tetragon(2, 4, 5, 6);
            y.CountPerimeter();
            y.CountArea();
            SecondTask.ConvexTetragon u = new SecondTask.ConvexTetragon(2, 4, 5, 6, 7, 7, 2);
            u.CountPerimeter();
            u.CountArea();
            SecondTask.Parallelogram i = new SecondTask.Parallelogram(2, 4, 5);
            i.CountPerimeter();
            i.CountArea();
            SecondTask.Rhombus o = new SecondTask.Rhombus(2, 4, 5);
            o.CountPerimeter();
            o.CountArea();
            SecondTask.Rectangle p = new SecondTask.Rectangle(2, 4);
            p.CountPerimeter();
            p.CountArea();
            SecondTask.Square l = new SecondTask.Square(2);
            l.CountPerimeter();
            l.CountArea();
        }
    }
}

using System;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            ShiftedCircle circle = new ShiftedCircle();
            circle.SetShift(Convert.ToDouble(Console.ReadLine()), float.Parse(Console.ReadLine()));
            circle.Draw();
        }
    }
}

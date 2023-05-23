using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Ork ork = new Ork("Fedor", 1000, 1);
            Wizard wizard = new Wizard("Harry Potter", 10, 1000);
            Warlock warlock = new Warlock("Gul Han", 1000, 1000);
            Console.WriteLine(ork.ToString()); 
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(warlock.ToString()); 
        }
    }
}
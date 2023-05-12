using System;

namespace Composit
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent root = new CompositSkill(false, "Вы какаете", "Покакать");
            IComponent skill1 = new CompositSkill(false, "Вы плачете", "Поплакать");
            IComponent skill2 = new CompositSkill(false, "Вы едите", "Поесть");
            IComponent skill3 = new LeafSkill(false, "Вы убиваете", "Авада кедавра");
            IComponent skill4 = new LeafSkill(false, "Вы умираете", "Smells like teen spirit");
            IComponent skill5 = new LeafSkill(false, "Вы кричите", "Dark souls");

            root.Add(skill1);
            root.Add(skill2);
            skill1.Add(skill3);
            skill2.Add(skill4);
            skill2.Add(skill5);

            root.Print();

            root.Explore();
            skill1.Explore();
            skill3.Explore();

            Console.WriteLine(new string('~', 33));

            root.Print();
        }
    }
}
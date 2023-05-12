using System;
using System.Collections.Generic;

namespace Composit
{
    class CompositSkill : IComponent
    {
        public bool Explored { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        private List<IComponent> _components = new List<IComponent>();

        public CompositSkill(bool explored, string description, string name)
        {
            Explored = explored;
            Description = description;
            Name = name;
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Description} {Explored}");
            foreach (IComponent component in _components)
            {
                component.Print();
            }
        }

        public void Explore()
        {
            Explored = true;
        }
    }
}
using System;

namespace Composit
{
    class LeafSkill : IComponent
    {
        public bool Explored { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public LeafSkill(bool explored, string description, string name)
        {
            Explored = explored;
            Description = description;
            Name = name;
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Description} {Explored}");
        }

        public void Explore()
        {
            Explored = true;
        }
    }
}
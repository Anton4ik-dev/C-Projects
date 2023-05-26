using System.Collections.Generic;

namespace Patterns2.Composite
{
    // объединяет группы объектов в древовидную структуру по принципу "часть-целое и позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }
        public override void Display()
        {
            System.Console.WriteLine(_name);
            for (int i = 0; i < _children.Count; i++)
            {
                _children[i].Display();
            }
        }
        public override void AddComponent(Component component)
        {
            _children.Add(component);
        }
        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}

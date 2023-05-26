namespace Patterns2.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Display()
        {
            System.Console.WriteLine(_name);
        }
        public override void AddComponent(Component component)
        {
        }
        public override void Remove(Component component)
        {
        }
    }
}

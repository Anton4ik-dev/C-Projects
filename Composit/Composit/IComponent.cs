namespace Composit
{
    public interface IComponent
    {
        public bool Explored { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public void Add(IComponent component);

        public void Print();
        public void Explore();
    }
}
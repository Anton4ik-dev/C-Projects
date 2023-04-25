namespace Patterns.PrototypePattern
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id) { }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(ID);
        }
    }
}
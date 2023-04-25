namespace Patterns.PrototypePattern
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id) { }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(ID);
        }
    }
}
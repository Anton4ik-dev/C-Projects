namespace Patterns2.Bridge
{
    public class Abstraction
    {
        public Implementor Implementor;

        public Abstraction(Implementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Operation() { }
    }
}
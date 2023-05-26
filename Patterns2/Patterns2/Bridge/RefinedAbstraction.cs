namespace Patterns2.Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor) { }

        public override void Operation()
        {
            Implementor.OperationImp();
        }
    }
}
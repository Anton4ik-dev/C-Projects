namespace Patterns2.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component?.Operation();
        }
    }
}
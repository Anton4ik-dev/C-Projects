namespace Patterns2.Adapter
{
    // предназначен для преобразования интерфейса одного класса в интерфейс другого
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
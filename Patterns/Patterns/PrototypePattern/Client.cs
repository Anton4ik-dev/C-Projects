namespace Patterns.PrototypePattern
{
    class Client
    {
        public Client()
        {
            Operation();
        }

        private void Operation()
        {
            // Создание и клонирование

            Prototype prototype1 = new ConcretePrototype1(0);
            Prototype prototype2 = new ConcretePrototype2(1);

            Prototype clone1 = prototype1.Clone();
            Prototype clone2 = prototype2.Clone();
        }
    }
}
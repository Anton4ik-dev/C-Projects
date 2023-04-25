using System;

namespace Patterns.AbstractfactoryPattern
{
    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            // Запуск клиента
            Console.WriteLine(abstractProductA.ToString());
            Console.WriteLine(abstractProductB.ToString());
        }
    }
}
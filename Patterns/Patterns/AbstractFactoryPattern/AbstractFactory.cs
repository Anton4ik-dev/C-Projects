namespace Patterns.AbstractfactoryPattern
{
    // Создается абстрактный класс фабрики, который создает абстрактные продукты
    // Можно использовать когда требуется гибкая реализация
    // И когда объекты должны использоваться вместе взаимосвязанно

    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA(); // Создание абстрактного продукта А
        public abstract AbstractProductB CreateProductB(); // Создание абстрактного продукта В
    }
}
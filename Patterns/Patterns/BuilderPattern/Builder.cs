namespace Patterns.BuilderPattern
{
    // Паттерн позваляет разделить на части логику создания объекта используя абстрактный класс
    // Можно использовать когда нужно комбинировать различные элементы, чтоб объект не зависел от них
    // И когда нужны разные варианты этого объекта

    abstract class Builder
    {
        public abstract void BuildPartA(); // Создание части А
        public abstract void BuildPartB(); // Создание части В
        public abstract void BuildPartC(); // Создание части С
        public abstract Product GetResult(); // Получение созданного объекта
    }
}
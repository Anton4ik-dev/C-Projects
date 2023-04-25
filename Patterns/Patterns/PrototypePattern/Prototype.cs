namespace Patterns.PrototypePattern
{
    // Паттерн позволяет создавать клоны уже созданных прототипов
    // Можно использовать когда нужно создавать разные прототипы и их клонирование предпочтительнее, чем создание через конструкторы

    abstract class Prototype
    {
        public int ID { get; set; }

        public Prototype(int id)
        {
            ID = id;
        }

        public abstract Prototype Clone(); // Клонирование прототипа
    }
}
// Паттерн, который создается один раз и гарантирует, что он будет один, а также он доступен из любомого места в коде
// Можно использоват, когда нужен только один экземпляр

class Singleton
{
    private static Singleton instance = null;

    public static Singleton Instance => instance != null // Создание и возвращение инстанса этого класса
        ? instance
        : instance = new Singleton();

    private Singleton() // Гарантия, что объект будет создан только один
    {

    }
}
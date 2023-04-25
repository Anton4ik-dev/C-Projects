namespace Patterns.BuilderPattern
{
    class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            // Создание объекта в билдере

            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
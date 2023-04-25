using System.Collections.Generic;

namespace Patterns.BuilderPattern
{
    class Product
    {
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            // Добавление части в объект

            parts.Add(part);
        }
    }
}
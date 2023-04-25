namespace Patterns.BuilderPattern
{
    class ConcreteBuilder : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("A");
        }

        public override void BuildPartB()
        {
            product.Add("B");
        }

        public override void BuildPartC()
        {
            product.Add("C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
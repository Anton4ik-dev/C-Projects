namespace Patterns2.Facade
{
    public class Facade
    {
        private SubSystemA _subSystemA;
        private SubSystemB _subSystemB;
        private SubSystemC _subSystemC;

        public Facade(SubSystemA subSystemA, SubSystemB subSystemB, SubSystemC subSystemC)
        {
            _subSystemA = subSystemA;
            _subSystemB = subSystemB;
            _subSystemC = subSystemC;
        }

        public void Operation1() { }

        public void Operation2() { }
    }
}
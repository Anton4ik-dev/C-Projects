namespace Decorator
{
    public class Ork : Character
    {
        public Ork(string name, int health, int mana) : base(name, health, mana) { }

        protected override void AddRace()
        {
            _race = "Ork";
        }
    }
}
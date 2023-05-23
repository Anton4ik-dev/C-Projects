namespace Decorator
{
    public class Goblin : Character
    {
        public Goblin(string name, int health, int mana) : base(name, health, mana) { }

        protected override void AddRace()
        {
            _race = "Goblin";
        }
    }
}
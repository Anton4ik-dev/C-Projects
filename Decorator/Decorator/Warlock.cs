namespace Decorator
{
    public class Warlock : Character
    {
        public Warlock(string name, int health, int mana) : base(name, health, mana) { }

        protected override void AddAbility()
        {
            _ability = new SummonMinion();
        }
    }
}
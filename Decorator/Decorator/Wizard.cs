namespace Decorator
{
    public class Wizard : Character
    {
        public Wizard(string name, int health, int mana) : base(name, health, mana) { }

        protected override void AddAbility()
        {
            _ability = new CastSpell();
        }
    }
}
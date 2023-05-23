namespace Decorator
{
    public abstract class Character : IAbility
    {
        protected string _name;
        protected int _health;
        protected int _mana;
        protected string _race;
        protected IAbility _ability;

        public Character(string name, int health, int mana)
        {
            _name = name;
            _health = health;
            _mana = mana;
            AddRace();
            AddAbility();
        }

        public override string ToString()
        {
            return $"{_name} {_health} {_mana} {_race} {_ability}";
        }

        public Effect Cast(Spell spell = default)
        {
            return _ability.Cast();
        }

        protected virtual void AddRace() { }

        protected virtual void AddAbility() { }
    }
}
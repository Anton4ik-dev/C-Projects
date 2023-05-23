namespace Decorator
{
    class CastSpell : IAbility
    {
        public Effect Cast(Spell spell)
        {
            return new Effect();
        }
    }
}
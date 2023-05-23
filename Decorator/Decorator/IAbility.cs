namespace Decorator
{
    public interface IAbility
    {
        public Effect Cast(Spell spell = default);
    }
}
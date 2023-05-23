using System;

namespace Decorator
{
    class SummonMinion : IAbility
    {
        public Effect Cast(Spell spell)
        {
            Console.WriteLine("Создан случайный миньон");
            return new Effect();
        }
    }
}
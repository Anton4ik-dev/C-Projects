namespace Decorator
{
    public class Human : Character
    {
        public Human(string name, int health, int mana) : base(name, health, mana) { }

        protected override void AddRace()
        {
            _race = "Human";
        }
    }
}
namespace FedotovAnton_Linq_DataBase
{
    class Person
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Person(int id, string level, string name)
        {
            Id = id;
            Level = level;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person) return Name == person.Name;
            return false;
        }
        public override int GetHashCode() => Name.GetHashCode();
    }
}
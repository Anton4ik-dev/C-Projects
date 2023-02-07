using System;

namespace FedotovAnton_Task_Tests
{
    public class RegularUser : IUser
    {
        public uint Balance { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public DateTime RegistrationDay { get; set; }
        public string Promotion { get; set; }

        public RegularUser(uint balance, string name, uint age)
        {
            Balance = balance;
            Name = name;
            Age = age;

            RandomDateTime randomDate = new RandomDateTime();
            RegistrationDay = randomDate.Next();
        }

        public void Instantiate()
        {
            if (Name.Length<= 3)
            {
                Name = null;
                throw new Exception("Wrong name");
            }
        }

        public void Enter()
        {
            Console.WriteLine($"Hello, {Name}");
        }

        public void AppStart()
        {
            Console.WriteLine($"Your balance is {Balance}$");

            if(Promotion != null)
                Console.WriteLine($"Your promotions are {Promotion}");
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                RegularUser p = (RegularUser)obj;
                return (Name == p.Name) && (Balance == p.Balance) && (Age == p.Age);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Balance, Age);
        }
    }
}
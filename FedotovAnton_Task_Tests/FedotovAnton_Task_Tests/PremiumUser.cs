using System;

namespace FedotovAnton_Task_Tests
{
    public class PremiumUser : IUser
    {
        public uint Balance { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public DateTime RegistrationDay { get; set; }
        public string Promotion { get; set; }

        public PremiumUser(uint balance, string name, uint age)
        {
            Balance = balance;
            Name = name;
            Age = age;

            RandomDateTime randomDate = new RandomDateTime();
            RegistrationDay = randomDate.Next();
        }

        public void Instantiate()
        {
            if (Name.Length <= 3)
            {
                Name = null;
                throw new Exception("Wrong name");
            }
        }

        public void Enter()
        {
            Console.WriteLine($"Hello, {Name}, we hope you're having a good day");
        }

        public void AppStart()
        {
            Console.WriteLine($"Your balance is {Balance}$");
            Console.WriteLine($"Have wonderful day");

            if (Promotion != null)
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
                PremiumUser p = (PremiumUser)obj;
                return (Name == p.Name) && (Balance == p.Balance) && (Age == p.Age);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Balance, Age);
        }
    }
}
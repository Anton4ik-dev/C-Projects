using System;
using System.Collections.Generic;

namespace FedotovAnton_Task_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IUser> users = new List<IUser> {
                new RegularUser(100, "Anton", 18),
                new RegularUser(200, "Lesha", 19),
                new RegularUser(300, "Nikita", 20),
                new RegularUser(400, "Serega", 17),
                new RegularUser(500, "LOSHARA", 22),
                new PremiumUser(1000, "GODOFWAR", 24),
                new PremiumUser(1200, "Roar", 27),
                new PremiumUser(1500, "Boots", 29),
                new PremiumUser(2000, "Puss", 12),
                new PremiumUser(10000, "AAAAA", 65)
            };

            UserApp app = new UserApp(users);
            app.GivePromotions();

            string input = Console.ReadLine();

            while(input != "")
            {
                app.UserEnterByName(input);
                input = Console.ReadLine();
            }
        }
    }
}
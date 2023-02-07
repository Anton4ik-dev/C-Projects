using System;
using System.Collections.Generic;
using System.Linq;

namespace FedotovAnton_Task_Tests
{
    public class UserApp
    {
        private List<IUser> _users;

        public UserApp(List<IUser> users)
        {
            _users = users;
        }

        public void GivePromotions()
        {
            int amountOfPromotionForPeople = 3;
            _users = _users.OrderBy(x => x.Age).ToList();

            for (int i = 0; i < amountOfPromotionForPeople; i++)
            {
                if (_users[i].GetType() == typeof(RegularUser) && _users[i].Name != null)
                    _users[i].Promotion = "1% cashback on all";
                else
                {
                    amountOfPromotionForPeople++;
                    if (amountOfPromotionForPeople == _users.Count)
                        break;
                }
            }

            amountOfPromotionForPeople = 5;
            _users = _users.OrderBy(x => x.RegistrationDay).ToList();

            for (int i = 0; i < amountOfPromotionForPeople; i++)
            {
                if (_users[i].GetType() == typeof(PremiumUser) && _users[i].Name != null)
                    _users[i].Promotion = "One free item every week";
                else
                {
                    amountOfPromotionForPeople++;
                    if (amountOfPromotionForPeople == _users.Count)
                        break;
                }
            }
        }

        public void UserEnterByName(string userName)
        {
            IUser user = _users.Find(x => x.Name == userName);

            if (user == null)
                throw new Exception("No user with this name");

            user.Enter();
            user.AppStart();
        }
    }
}
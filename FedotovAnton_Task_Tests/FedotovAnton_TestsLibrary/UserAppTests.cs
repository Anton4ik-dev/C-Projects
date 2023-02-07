using Microsoft.VisualStudio.TestTools.UnitTesting;
using FedotovAnton_Task_Tests;
using System.Collections.Generic;
using System;

namespace FedotovAnton_TestsLibrary
{
    [TestClass]
    public class UserAppTests
    {
        static private List<IUser> _users = new List<IUser> {
                new RegularUser(100, "Anton", 18),
                new RegularUser(200, "Lesha", 19),
                new RegularUser(300, "Nikita", 20),
                new RegularUser(500, "LOSHARA", 22),
                new PremiumUser(1000, "GODOFWAR", 24),
                new PremiumUser(1200, "Roar", 27),
                new PremiumUser(1500, "Boots", 29),
                new PremiumUser(2000, "Puss", 12),
                new PremiumUser(10000, "AAAAA", 65),
                new PremiumUser(1000000, "PONIAL", 55)
            };
        public static IEnumerable<object[]> AdditionalData1
        {
            get
            {
                return new[]
                {
                    new object[] { new RegularUser(100, "Anton", 18), new PremiumUser(1000, "Gugo", 20) },
                    new object[] { new RegularUser(200, "Leha", 19), new PremiumUser(2000, "Stomper", 21) },
                    new object[] { new RegularUser(300, "Normal", 20), new PremiumUser(3000, "Rodger", 22) },
                    new object[] { new RegularUser(400, "Popstar", 21), new PremiumUser(4000, "Poper", 23) },
                    new object[] { new RegularUser(500, "Grisha", 22), new PremiumUser(5000, "Perez", 24) }
                };
            }
        }
        public static IEnumerable<object[]> AdditionalData2
        {
            get
            {
                return new[]
                {
                    new object[] { new RegularUser(100, "An", 18), new PremiumUser(1000, "Gugo", 20) },
                    new object[] { new RegularUser(200, "Leha", 19), new PremiumUser(2000, "Sto", 21) },
                    new object[] { new RegularUser(300, "Normal", 20), new PremiumUser(3000, "Rer", 22) },
                    new object[] { new RegularUser(400, "Pop", 21), new PremiumUser(4000, "Poper", 23) },
                    new object[] { new RegularUser(500, "Grisha", 22), new PremiumUser(5000, "Per", 24) }
                };
            }
        }

        [TestMethod]
        public void CheckUsers_Equivalent()
        {
            List<IUser> newUsers = new List<IUser> {
                new RegularUser(100, "Anton", 18),
                new RegularUser(200, "Lesha", 19),
                new PremiumUser(1000, "GODOFWAR", 24),
                new PremiumUser(1200, "Roar", 27),
                new PremiumUser(1500, "Boots", 29),
                new RegularUser(300, "Nikita", 20),
                new RegularUser(500, "LOSHARA", 22),
                new PremiumUser(2000, "Puss", 12),
                new PremiumUser(10000, "AAAAA", 65),
                new PremiumUser(1000000, "PONIAL", 55)
            };

            CollectionAssert.AreEquivalent(newUsers, _users);
        }

        [TestMethod]
        [DynamicData(nameof(AdditionalData1))]
        public void Users_FromDynamicDataTest(RegularUser regUser, PremiumUser premUser)
        {
            bool isRegular = false;
            bool isPremium = false;

            if (regUser.Name.Length > 3 && regUser.RegistrationDay != null)
                isRegular = true;

            if (premUser.Name.Length > 3 && premUser.RegistrationDay != null)
                isPremium = true;

            Assert.IsTrue(isRegular);
            Assert.IsTrue(isPremium);
        }

        [ExpectedException(typeof(Exception), "no exception")]
        [TestMethod]
        [DynamicData(nameof(AdditionalData2))]
        public void Users_FromDynamicDataTest_Exception(RegularUser regUser, PremiumUser premUser)
        {
            regUser.Instantiate();
            premUser.Instantiate();
        }
    }
}
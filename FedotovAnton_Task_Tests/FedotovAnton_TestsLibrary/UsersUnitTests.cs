using Microsoft.VisualStudio.TestTools.UnitTesting;
using FedotovAnton_Task_Tests;
using System;

namespace FedotovAnton_TestsLibrary
{
    [TestClass]
    public class UsersUnitTests
    {
        private RegularUser _regularUser = new RegularUser(100, "Anton", 18);
        private PremiumUser _premiumUser = new PremiumUser(1000, "Rich", 30);

        [TestMethod]
        public void CheckParameters()
        {
            bool isRegular = false;
            bool isPremium = false;

            if (_regularUser.Name.Length > 3 && _regularUser.RegistrationDay != null)
                isRegular = true;

            if (_premiumUser.Name.Length > 3 && _premiumUser.RegistrationDay != null)
                isPremium = true;

            Assert.IsTrue(isRegular);
            Assert.IsTrue(isPremium);
        }

        [ExpectedException(typeof(Exception), "no exception")]
        [TestMethod]
        public void CheckName_Exception()
        {
            _regularUser = new RegularUser(100, "AA", 10);
            _premiumUser = new PremiumUser(1000, "OAO", 20);

            _regularUser.Instantiate();
            _premiumUser.Instantiate();
        }
    }
}
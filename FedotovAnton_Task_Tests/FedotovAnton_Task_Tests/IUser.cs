using System;

namespace FedotovAnton_Task_Tests
{
    public interface IUser
    {
        uint Balance { get; set; }
        string Name { get; set; }
        uint Age { get; set; }
        DateTime RegistrationDay { get; set; }
        string Promotion { get; set; }

        void Instantiate();

        void Enter();

        void AppStart();
    }
}
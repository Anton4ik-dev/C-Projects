using System;

namespace FedotovAnton_Task_Tests
{
    public class RandomDateTime
    {
        private DateTime _startDate;
        private Random _rnd;
        private int _range;

        public RandomDateTime()
        {
            _startDate = new DateTime(1995, 1, 1);
            _rnd = new Random();
            _range = (DateTime.Today - _startDate).Days;
        }

        public DateTime Next()
        {
            return _startDate.AddDays(_rnd.Next(_range)).AddHours(_rnd.Next(0, 24)).AddMinutes(_rnd.Next(0, 60)).AddSeconds(_rnd.Next(0, 60));
        }
    }
}
﻿namespace Patterns2.Proxy
{
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();
            _realSubject.Request();
        }
    }
}
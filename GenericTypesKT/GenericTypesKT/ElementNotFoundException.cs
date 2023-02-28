using System;

namespace GenericTypesKT
{
    class ElementNotFoundException : Exception
    {
        public override string Message { get => "Dictionary doesn't contains element with this key or value"; }
    }
}
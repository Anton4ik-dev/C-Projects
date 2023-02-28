using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericTypesKT
{
    class TestDictionary<T1, T2> : IEnumerable<TestKeyValuePairs<T1, T2>>, IEnumerator<TestKeyValuePairs<T1, T2>>
    {
        private List<TestKeyValuePairs<T1, T2>> _dictionary;

        private int _position = -1; 

        public TestDictionary(List<TestKeyValuePairs<T1, T2>> dictionary)
        {
            _dictionary = dictionary;
        }

        public TestKeyValuePairs<T1, T2> Current
        {
            get
            {
                if (_position == -1 || _position >= _dictionary.Count)
                    throw new ArgumentException();
                return _dictionary[_position];
            }
        }

        object IEnumerator.Current => Current;

        public void AddKey(T1 key, T2 value) => _dictionary.Add(new TestKeyValuePairs<T1, T2>(key, value));

        public void RemoveByKey(T1 key)
        {
            for (int i = 0; i < _dictionary.Count; i++)
            {
                if(_dictionary[i].Key.ToString() == key.ToString())
                {
                    _dictionary.RemoveAt(i);
                    return;
                }
            }

            throw new ElementNotFoundException();
        }

        public void RemoveByValue(T2 value)
        {
            for (int i = 0; i < _dictionary.Count; i++)
            {
                if (_dictionary[i].Value.ToString() == value.ToString())
                {
                    _dictionary.RemoveAt(i);
                    return;
                }
            }
            
            throw new ElementNotFoundException();
        }

        public TestKeyValuePairs<T1, T2> FindByKey(T1 key)
        {
            for (int i = 0; i < _dictionary.Count; i++)
            {
                if (_dictionary[i].Key.ToString() == key.ToString())
                    return _dictionary[i];
            }

            throw new ElementNotFoundException();
        }

        public TestKeyValuePairs<T1, T2> FindByValue(T2 value)
        {
            for (int i = 0; i < _dictionary.Count; i++)
            {
                if (_dictionary[i].Value.ToString() == value.ToString())
                    return _dictionary[i];
            }

            throw new ElementNotFoundException();
        }

        public IEnumerator<TestKeyValuePairs<T1, T2>> GetEnumerator() => _dictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool MoveNext()
        {
            if (_position < _dictionary.Count - 1)
            {
                _position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => _position = -1;

        public void Dispose() { }
    }
}
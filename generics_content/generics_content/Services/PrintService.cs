using System;

namespace Services
{
    public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print service is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Print service is null");
            }

            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                if (i <= _count - 1)
                {
                    Console.Write(_values[i] + ", ");
                }
            }
            Console.Write(_values[_count - 1] + "]");
            Console.WriteLine();
        }
    }
}


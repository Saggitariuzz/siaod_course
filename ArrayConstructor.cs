using System;

namespace app
{
    internal class ArrayConstructor
    {
        public ArrayConstructor() { }

        public static int[] createNotOrdered(int _size)
        {
            int[] _array = new int[_size];
            Random _random = new Random();
            for(int i = 0; i < _size; i++)
            {
                _array[i] = _random.Next(1,_size);
            }
            return _array;
        }

        public static int[] createOrdered(int _size)
        {
            int[] _array = new int[_size];
            Random _random = new Random();
            _array[0] = _random.Next(1,5);
            for(int i = 1;i< _size; i++)
            {
                _array[i] = _array[i-1] + _random.Next(1, 5);
            }
            return _array;
        }

        public static int[] createReverseOrdered(int _size)
        {
            int[] _array = new int[_size];
            Random _random = new Random();
            _array[_size - 1] = _random.Next(1, 5);
            for(int i = _size - 2; i >= 0; i--)
            {
                _array[i] = _array[i + 1] + _random.Next(1, 5);
            }
            return _array;
        }

        public static int[] createPartlyOrdered(int _size, int _percent) {
            int[] _array = new int[_size];
            Random _random = new Random();
            _array[0] = _random.Next(1, 5);
            for(int i = 1; i < _size * _percent / 100; i++)
            {
                _array[i] = _array[i-1] + _random.Next(1, 5);
            }
            for(int i = _size*_percent / 100; i < _size; i++)
            {
                _array[i] = _random.Next(1, _size);
            }
            return _array;
        }
    }
}

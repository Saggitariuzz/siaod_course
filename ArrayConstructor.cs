using System;
using System.Runtime.ExceptionServices;

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

        public static int bubbleSort(int[] _array)
        {
            int N = _array.Length;
            int StartTime = Environment.TickCount;
            for (int i = 1; i < N; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < N - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        int temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public static int shakerSort(int[] _array)
        {
            int Left = 0;
            int Right = _array.Length - 1;
            int StartTime = Environment.TickCount;
            while(Left<Right)
            {
                bool isSwapped = false;
                for(int i = Left; i < Right; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        int temp = _array[i];
                        _array[i] = _array[i+1];
                        _array[i+1] = temp;
                        isSwapped = true;
                    }
                }
                Right--;
                for(int i = Right; i > Left; i--)
                {
                    if (_array[i - 1] > _array[i])
                    {
                        int temp = _array[i];
                        _array[i] = _array[i - 1];
                        _array[i - 1] = temp;
                        isSwapped = true;
                    }
                }
                Left++;
                if (!isSwapped)
                {
                    break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public static int savePositionBubbleSort(int[] _array)
        {
            int N = _array.Length;
            int lastSwap = N - 1;
            int StartTime = Environment.TickCount;
            while(lastSwap > 0)
            {
                int swapIndex = 0;
                for(int i = 0;i < lastSwap;i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        int temp = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = temp;
                        swapIndex = i;
                    }
                }
                lastSwap = swapIndex;
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }
    }
}

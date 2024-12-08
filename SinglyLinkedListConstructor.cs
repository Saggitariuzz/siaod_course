using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    internal class SinglyLinkedList 
    {

        private class Node
        {
            public int _value;
            public Node _next;
            public Node(int value)
            {
                _value = value;
                _next = null;
            }

            public Node(int value, Node next)
            {
                _value = value;
                _next = next;
            }
        }

        private Node _first;

        private Node _last;

        private int _length;

        public SinglyLinkedList() { 
            _first = null;
            _last = null;
            _length = 0;
        }

        public void Add(int value)
        {
            Node node = new Node(value);
            if (_first == null)
            {
                _first = node;
                _last = node;
            }
            else
            {
                _last._next = node;
                _last = node;
            }
                
            _length++;
        }

        public void RemoveLast()
        {
            if(_first == null)
            {
                return;
            }
            if(_first._next == null)
            {
                _first = null;
                _last = null;
                _length--;
                return;
            }
            Node tmp = _first;
            while (tmp._next != _last)
            {
                tmp = tmp._next;
            }
            tmp._next = null;
            _last = tmp;
            _length--;
        }

        public static SinglyLinkedList createNotOrdered(int size)
        {
            SinglyLinkedList tmp = new SinglyLinkedList();
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                tmp.Add(rnd.Next(1,size));
            }
            return tmp;
        }

        public static SinglyLinkedList createOrdered(int size)
        {
            SinglyLinkedList tmp = new SinglyLinkedList();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            tmp.Add(prev);
            for(int i = 1; i < size; i++)
            {
                prev += rnd.Next(1, 5);
                tmp.Add(prev);
            }
            return tmp;
        }

        public static SinglyLinkedList createReverseOrdered(int size)
        {
            SinglyLinkedList tmp = SinglyLinkedList.createOrdered(size);
            SinglyLinkedList reverse = new SinglyLinkedList();
            for(int i = 0; i < size; i++)
            {
                int node = tmp._last._value;
                reverse.Add(node);
                tmp.RemoveLast();
            }
            return reverse;
        }

        public static SinglyLinkedList createPartlyOrdered(int size, int percent)
        {
            SinglyLinkedList tmp = new SinglyLinkedList();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            tmp.Add(prev);
            for (int i = 1; i < size*percent/100; i++)
            {
                prev += rnd.Next(1, 5);
                tmp.Add(prev);
            }
            for(int i = size*percent/100; i < size; i++)
            {
                tmp.Add(rnd.Next(1, size));
            }
            return tmp;
        }

        public static int bubbleSort(SinglyLinkedList list)
        {
            int N = list.Length();
            int StartTime = Environment.TickCount;
            for (int i = 1; i < N; i++)
            {
                Node current = list._first;
                bool isSorted = true;
                for (int j = 0; j < N - i; j++)
                {
                    if (current._value > current._next._value)
                    {
                        int temp = current._value;
                        current._value = current._next._value;
                        current._next._value = temp;
                        isSorted = false;
                    }
                    current = current._next;
                }
                if (isSorted)
                {
                    break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public static int shakerSort(SinglyLinkedList list)
        {
            int Left = 0;
            int Right = list.Length() - 1;
            int StartTime = Environment.TickCount;
            while (Left < Right)
            {
                bool isSwapped = false;
                Node current = list._first;
                for (int i = Left; i < Right; i++)
                {
                    if (current._value > current._next._value)
                    {
                        int temp = current._value;
                        current._value = current._next._value;
                        current._next._value = temp;
                        isSwapped = true;
                    }
                    current = current._next;
                }
                Right--;
                if (!isSwapped)
                {
                    break;
                }
                for (int i = Right; i > Left; i--)
                {
                    Node prev = null;
                    current = list._first;
                    for (int j = 0; j < i; j++)
                    {
                        prev = current;
                        current = current._next;
                    }
                    if (prev._value > current._value)
                    {
                        int temp = prev._value;
                        prev._value = current._value;
                        current._value = temp;
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

        public static int savePositionBubbleSort(SinglyLinkedList list)
        {
            int N = list.Length();
            int lastSwap = N - 1;
            int StartTime = Environment.TickCount;
            while (lastSwap > 0)
            {
                int swapIndex = 0;
                Node current = list._first;
                for(int i = 0;i < lastSwap; i++)
                {
                    if(current._value > current._next._value)
                    {
                        int temp = current._value;
                        current._value = current._next._value;
                        current._next._value = temp;
                        swapIndex = i;
                    }
                    current = current._next;
                }
                lastSwap = swapIndex;
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public int Length()
        {
            return _length;
        }
    }
}

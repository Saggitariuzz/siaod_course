using System;


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



        public int Length()
        {
            return _length;
        }
    }
}

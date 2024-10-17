using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class SinglyLinkedListConstructor
    {

        public class Node
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

        private int _length;

        public SinglyLinkedListConstructor() { 
            _first = null;
            _length = 0;
        }

        public void Add(Node node)
        {
            if (_first == null)
            {
                _first = node;
            }
            else
            {
                Node tmp = _first;
                while(tmp._next != null)
                {
                    tmp = tmp._next;
                }
                tmp._next = node;
            }
            _length++;
        }

        public int Get(int index)
        {
            if(index < 0 || index>=_length)
            {
                return -1;
            }
            int currentindex = 0;
            Node tmp = _first;
            while(tmp!=null)
            {
                if(index == currentindex)
                {
                    return tmp._value;
                }
                tmp = tmp._next;
                currentindex++;
            }
            return -1;
        }

        public static SinglyLinkedListConstructor createNotOrdered(int size)
        {
            SinglyLinkedListConstructor tmp = new SinglyLinkedListConstructor();
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                tmp.Add(new Node(rnd.Next(1, size)));
            }
            return tmp;
        }

        public static SinglyLinkedListConstructor createOrdered(int size)
        {
            SinglyLinkedListConstructor tmp = new SinglyLinkedListConstructor();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            tmp.Add(new Node(prev));
            for(int i = 1; i < size; i++)
            {
                prev += rnd.Next(1, 5);
                tmp.Add(new Node(prev));
            }
            return tmp;
        }

        public static SinglyLinkedListConstructor createReverseOrdered(int size)
        {
            SinglyLinkedListConstructor tmp = SinglyLinkedListConstructor.createOrdered(size);
            SinglyLinkedListConstructor reverse = new SinglyLinkedListConstructor();
            for(int i = size-1; i >= 0; i--)
            {
                reverse.Add(new Node(tmp.Get(i)));
            }
            return reverse;
        }

        public static SinglyLinkedListConstructor createPartlyOrdered(int size, int percent)
        {
            SinglyLinkedListConstructor tmp = new SinglyLinkedListConstructor();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            tmp.Add(new Node(prev));
            for (int i = 1; i < size*percent/100; i++)
            {
                prev += rnd.Next(1, 5);
                tmp.Add(new Node(prev));
            }
            for(int i = size*percent/100; i < size; i++)
            {
                tmp.Add(new Node(rnd.Next(1, size)));
            }
            return tmp;
        }

        public int Length()
        {
            return _length;
        }
    }
}

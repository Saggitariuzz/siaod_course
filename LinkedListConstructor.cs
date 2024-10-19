using System;
using System.Collections.Generic;


namespace app
{
    internal class LinkedListConstructor
    {

        public LinkedListConstructor() { }

        public static LinkedList<int> createNotOrdered(int size)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                list.AddLast(rnd.Next(1, size));
            }
            return list;
        }

        public static LinkedList<int> createOrdered(int size)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            list.AddFirst(prev);
            for (int i = 1; i < size; i++)
            {
                prev += rnd.Next(1, 5);
                list.AddLast(prev);
            }
            return list;
        }

        public static LinkedList<int> createReverseOrdered(int size)
        {
            LinkedList<int> list = LinkedListConstructor.createOrdered(size);
            LinkedList<int> reverse = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                reverse.AddLast(list.Last.Value);
                list.RemoveLast();
            }
            return reverse;
        }

        public static LinkedList<int> createPartlyOrdered(int size, int percent)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rnd = new Random();
            int prev = rnd.Next(1, 5);
            list.AddFirst(prev);
            for (int i = 1; i < size * percent / 100; i++)
            {
                prev += rnd.Next(1, 5);
                list.AddLast(prev);
            }
            for (int i = size * percent / 100; i < size; i++)
            {
                list.AddLast(rnd.Next(1, size));
            }
            return list;
        }
    }
}

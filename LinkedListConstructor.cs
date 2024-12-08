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

        public static int bubbleSort(LinkedList<int> list)
        {
            int N = list.Count;
            int StartTime = Environment.TickCount;
            for(int i = 1;i < N; i++)
            {
                var current = list.First;
                bool isSorted = true;
                for(int j = 0; j < N - i; j++)
                {
                    if(current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        isSorted = false;
                    }
                    current = current.Next;
                }
                if (isSorted)
                {
                    break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public static int shakerSort(LinkedList<int> list)
        {
            int Left = 0;
            int Right = list.Count - 1;
            int StartTime = Environment.TickCount;
            while(Left < Right)
            {
                bool isSwapped = false;
                var current = list.First;
                for(int i = Left;i<Right;i++) {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        isSwapped = true;
                    }
                    current = current.Next;
                }
                Right--;
                if (!isSwapped)
                {
                    break;
                }
                for (int i = Right;i>Left;i--) {
                    if(current.Previous.Value > current.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Previous.Value;
                        current.Previous.Value = temp;
                        isSwapped = true;
                    }
                }
                Left++;
                if(!isSwapped)
                {
                    break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        public static int savePositionBubbleSort(LinkedList<int> list)
        {
            int N = list.Count;
            int lastSwap = N - 1;
            int StartTime = Environment.TickCount;
            while(lastSwap > 0)
            {
                int swapIndex = 0;
                var current = list.First;
                for(int i = 0;i<lastSwap;i++)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapIndex = i;
                    }
                    current = current.Next;
                }
                lastSwap = swapIndex;
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }
    }
}

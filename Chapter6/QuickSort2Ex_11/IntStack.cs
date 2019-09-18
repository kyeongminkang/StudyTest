using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2Ex_11
{
    public class IntStack
    {
        private int max;
        private int ptr;
        // private static int ptr;
        private int[] stk;

        // stack private인 이유! 다른데서 사용해버리면 stack자체 의미가 없음!

        public class EmptyIntStackException : Exception
        {
            public EmptyIntStackException() { }

        }

        public class OverflowIntStackExcption : Exception
        {
            public OverflowIntStackExcption() { }
        }

        public IntStack(int capacity)
        {
            ptr = 0;
            max = capacity;
            try
            {
                stk = new int[max];

            }
            catch (OutOfMemoryException)
            {
                max = 0;
            }
        }

        public int push(int x)
        {
            if (ptr >= max)
            {
                throw new OverflowException();
            }
            return stk[ptr++] = x;

        }

        public int pop()
        {
            if (ptr <= 0)
            {
                throw new EmptyIntStackException();
            }
            return stk[--ptr];
        }

        public int peek()
        {
            if (ptr <= 0)
            {
                throw new EmptyIntStackException();
            }
            return stk[ptr - 1];
        }

        public int indexOf(int x)
        {
            for (int i = ptr - 1; i >= 0; i--)
            {
                if (stk[i] == x)
                    return i;
            }
            return -1;
        }

        public void clear()
        {
            ptr = 0;
        }

        public int capacity()
        {
            return max;
        }

        public int size()
        {
            return ptr;
        }

        public bool isEmpty()
        {
            return ptr <= 0;
        }

        public bool isFull()
        {
            return ptr >= max;
        }

        public void dump()
        {
            if (ptr <= 0)
                Console.WriteLine("스택이 비어 있습니다.");
            else
                for (int i = 0; i < ptr; i++)
                {
                    Console.Write(stk[i] + " ");

                }
            Console.WriteLine();

        }

    }
}

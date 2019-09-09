using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack_3
{
    class IntStack_3
    {

        private int max;
        private int ptrA;
        private int ptrB;
        private int[] stk;

        public enum AorB
        {
            StackA, StackB
        };

        public class EmptyIntStackException : Exception
        {
            public EmptyIntStackException() { }

        }

        public class OverflowIntStackExcption : Exception
        {
            public OverflowIntStackExcption() { }
        }

        public IntStack_3(int capacity)
        {
            ptrA = 0;
            ptrB = 0;
            max = capacity;
            try
            {
                stk = new int[max];
            }
            catch
            {
                max = 0;
            }
        }

        public int push(AorB ab, int x)
        {
            if (ptrA >= ptrB + 1)
                throw new OverflowIntStackExcption();
            switch (ab)
            {
                case AorB.StackA:
                    stk[ptrA++] = x;
                    break;
                case AorB.StackB:
                    stk[ptrB--] = x;
                    break;
            }
            return x;
        }

        public int pop(AorB ab)
        {
            int x = 0;
            switch (ab)
            {
                case AorB.StackA:
                    if (ptrA <= 0)
                        throw new EmptyIntStackException();
                    x = stk[--ptrA];
                    break;

                case AorB.StackB:
                    if (ptrB >= max - 1)
                        throw new EmptyIntStackException();
                    x = stk[++ptrB];
                    break;
            }
            return x;
        }

        public int peep(AorB ab)
        {
            int x = 0;
            switch (ab)
            {
                case AorB.StackA:
                    if (ptrA <= 0)
                        throw new EmptyIntStackException();
                    x = stk[ptrA - 1];
                    break;

                case AorB.StackB:
                    if (ptrB >= max - 1)
                        throw new EmptyIntStackException();
                    x = stk[ptrB + 1];
                    break;
            }
            return x;
        }

        public int indexOf(AorB ab, int x)
        {
            switch (ab)
            {
                case AorB.StackA:
                    for (int i = ptrA - 1; i >= 0; i--)
                        if (stk[i] == x)
                            return i;
                    break;

                case AorB.StackB:
                    for (int i = ptrB + 1; i < max; i++)
                        if (stk[i] == x)
                            return i;
                    break;
            }
            return -1;
        }

        public void clear(AorB ab)
        {
            switch (ab)
            {
                case AorB.StackA:
                    ptrA = 0;
                    break;

                case AorB.StackB:
                    ptrB = 0;
                    break;
            }
        }

        public int capacity()
        {
            return max;
        }
        public int size(AorB ab)
        {
            switch (ab)
            {
                case AorB.StackA:
                    return ptrA;

                case AorB.StackB:
                    return max - ptrB - 1;
            }
            return 0;
        }

        public bool isEmpty(AorB ab)
        {
            switch (ab)
            {
                case AorB.StackA:
                    return ptrA <= 0;

                case AorB.StackB:
                    return ptrB >= max -1;
            }
            return true;
        }

        public bool isFull()
        {
            return ptrA >= ptrB + 1;
        }

        public void dump(AorB ab)
        {
            switch (ab)
            {
                case AorB.StackA:
                    if (ptrA <= 0)
                        Console.WriteLine("스택이 비어있습니다.");
                    else
                    {
                        for (int i = 0; i < ptrA; i++)
                            Console.Write(stk[i] + " ");
                        Console.WriteLine();
                    }
                    break;

                case AorB.StackB:
                    if (ptrB >= max - 1)
                        Console.WriteLine("스택이 비어있습니다.");
                    else
                    {
                        for (int i = max - 1; i > ptrB; i--)
                            Console.Write(stk[i] + " ");
                        Console.WriteLine();
                    }
                    break;
            }
        }


        static void Main(string[] args)
        {
        }
    }
}

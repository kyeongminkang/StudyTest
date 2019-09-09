using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public class IntStack
    {
        private int max;
        private int ptr;
        private int[] stk;

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
            catch (OutOfMemoryException e)
            {
                max = 0;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

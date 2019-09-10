using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gstack_2
{
    class Gstack_2
    {
        private int max;
        private int ptr;
        private Object[] stk;

        public Gstack_2(int capacity)
        {
            ptr = 0;
            max = capacity;
            try
            {
                stk = (Object[])new Object();
            }
            catch
            {
                max = 0;
            }
        }

        public Object push(Object x)
        {
            if (ptr >= max)
                Console.WriteLine("스택이 가득 참");
            return stk[ptr++] = x;
        }

        static void Main(string[] args)
        {
        }
    }
}

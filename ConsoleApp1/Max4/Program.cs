using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max4
{
    class Program
    {
        static int max4(int a, int b, int c, int d)
        {
            int max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;

            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("max4(1, 5, 9, 2) = " + max4(1, 5, 9, 2));
        }
    }
}

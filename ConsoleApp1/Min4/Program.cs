using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min4
{
    class Program
    {
        static int min4(int a, int b, int c, int d)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            if (d < min)
                min = d;

            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("min4(4, 2, 1, 6) = " + min4(4, 2, 1, 6));
        }
    }
}

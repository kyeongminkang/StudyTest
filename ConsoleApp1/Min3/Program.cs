using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min3
{
    class Program
    {
        static int min3(int a, int b, int c)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;

            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("min3(6, 2, 4) = " + min3(6, 2, 4));
        }
    }
}

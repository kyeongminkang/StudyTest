using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med3m
{
    class Program
    {
        static int med3m(int a, int b, int c)
        {
            if (a >= b)
                if (b >= c)
                    return b;
                else if (a <= c)
                    return a;
                else return c;

            else if (a > c)
                return a;
            else if (b > c)
                return c;
            else return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("med3m(13, 12, 11) = " + med3m(13, 12, 11));
            Console.WriteLine("med3m(13, 11, 11) = " + med3m(13, 11, 11));
            Console.WriteLine("med3m(13, 11, 12) = " + med3m(13, 11, 12));
            Console.WriteLine("med3m(13, 12, 13) = " + med3m(13, 12, 13));
            Console.WriteLine("med3m(12, 11, 13) = " + med3m(12, 11, 13));
            Console.WriteLine("med3m(13, 13, 12) = " + med3m(13, 13, 12));
            Console.WriteLine("med3m(13, 13, 13) = " + med3m(13, 13, 13));
            Console.WriteLine("med3m(12, 12, 13) = " + med3m(12, 12, 13));
            Console.WriteLine("med3m(12, 13, 11) = " + med3m(12, 13, 11));
            Console.WriteLine("med3m(12, 13, 12) = " + med3m(12, 13, 12));
            Console.WriteLine("med3m(11, 13, 12) = " + med3m(11, 13, 12));
            Console.WriteLine("med3m(12, 13, 13) = " + med3m(12, 13, 13));
            Console.WriteLine("med3m(11, 12, 13) = " + med3m(11, 12, 13));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3m
{
    class Max3m
    {
        static int Max3(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
                
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("max3(3, 2, 1) = " + Max3(3, 2, 1));
            Console.WriteLine("max3(3, 2, 2) = " + Max3(3, 2, 2));
            Console.WriteLine("max3(3, 1, 2) = " + Max3(3, 1, 2));
            Console.WriteLine("max3(3, 2, 3) = " + Max3(3, 2, 3));
            Console.WriteLine("max3(2, 1, 3) = " + Max3(2, 1, 3));
            Console.WriteLine("max3(3, 3, 2) = " + Max3(3, 3, 2));
            Console.WriteLine("max3(3, 3, 3) = " + Max3(3, 3, 3));
            Console.WriteLine("max3(2, 2, 3) = " + Max3(2, 2, 3));
            Console.WriteLine("max3(2, 3, 1) = " + Max3(2, 3, 1));
            Console.WriteLine("max3(2, 3, 2) = " + Max3(2, 3, 2));
            Console.WriteLine("max3(1, 3, 2) = " + Max3(1, 3, 2));
            Console.WriteLine("max3(2, 3, 3) = " + Max3(2, 3, 3));
            Console.WriteLine("max3(1, 2, 3) = " + Max3(1, 2, 3));
            Console.WriteLine("max3(3, 2, 1) = " + Max3(3, 2, 1));
        }
    }
}

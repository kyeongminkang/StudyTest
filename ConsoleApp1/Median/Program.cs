using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    class Program
    {
        static int med3(int a, int b, int c)
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
            Console.WriteLine("세 정수의 중앙값을 구합니다.");
            Console.Write("1. a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.Write("2. b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            Console.Write("3. c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c);

            Console.WriteLine("중앙값은 " + med3(a, b, c) + "입니다");
        }
    }
}

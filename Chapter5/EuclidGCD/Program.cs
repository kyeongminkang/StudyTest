using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGCD
{
    class Program
    {
        static int gcd(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return gcd(y, x%y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("두 정수의 최대공약수를 구합니다.");

            Console.Write("정수를 입력하세요. : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("정수를 입력하세요. : ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("최대공약수는 " + gcd(x, y) + "입니다.");
        }
    }
}

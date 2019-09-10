using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcd2_2
{
    class Program
    {
        static int gcd(int x, int y)
        {
            //int a = 0;

            //for (int i = y; i > 0; i--)
            //    if (x % i == 0 && y % i == 0)
            //    {
            //        a = i;
            //        break;
            //    }
                 
            //return a; 

            while(y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;

            }
            return x;
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

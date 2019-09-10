using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial2_1
{
    class Program
    {
        static int factorial(int n)
        {
            int num = 1;

            //for (int i = 1; i < n + 1; i++)
            //    num *= i;

            while (n > 1)
                num *= n--;

            return num;
        }
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + "의 팩토리얼은 " + factorial(x) + "입니다.");
        }
    }
}

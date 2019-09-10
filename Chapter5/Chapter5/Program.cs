using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static int factorial(int n)
        {
            if (n > 0)
                return n * factorial(n - 1);
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + "의 팩토리얼은 " + factorial(x) + "입니다.");
        }
    }
}

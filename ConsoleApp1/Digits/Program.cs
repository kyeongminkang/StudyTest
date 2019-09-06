using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("2자리의 정수를 입력하세요.");

            do
            {
                Console.Write("n을 입력 :");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n < 10 || n > 99);

            Console.WriteLine("n의 값은 " + n + "입니다.");
        }
    }
}

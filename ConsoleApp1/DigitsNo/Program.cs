using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요.");
            int n;

            //while (true)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.WriteLine("양의 정수를 입력하세요.");
            //}

            //if (n < 10)
            //{
            //    Console.WriteLine(n + "은 1자리 수입니다.");
            //}
            //else if (n / 10 < 10)
            //{
            //    Console.WriteLine(n + "은 2자리 수입니다.");

            //}else if (n / 100 < 10)
            //{
            //    Console.WriteLine(n + "은 3자리 수 입니다.");
            //}

            do
            {
                Console.WriteLine("양의 정수를 입력하세요");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            int no = 0;
            while(n > 0)
            {
                n /= 10;
                no++;
            }

            Console.WriteLine("그 수는 " + no + "자리 수입니다.");


        }
    }
}

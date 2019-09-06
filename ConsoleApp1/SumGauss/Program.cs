using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGauss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요");
            int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //if (n%2 == 0)
            //{
            //    sum = (1 + n) * (n / 2);
            //}else
            //{
            //    sum = (1 + n) * (n / 2) + ((n + 1) / 2);
            //}

            //Console.WriteLine("1부터 " + n + "까지의 합은 " + sum + "입니다.");

            int sum = (1 + n) * (n / 2) + (n % 2 == 1 ? (n + 1) / 2 : 0);
            Console.WriteLine("1부터 " + n + "까지의 합은 " + sum + "입니다.");

        }
    }
}

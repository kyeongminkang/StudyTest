using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumForPos
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine("1부터 n까지의 합을 구합니다.");

            do
            {
                Console.Write("n의 값을 입력하세요 : ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n <= 0);

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("1부터 " + n + "까지의 합은 " + sum + "입니다.");
        }
    }
}

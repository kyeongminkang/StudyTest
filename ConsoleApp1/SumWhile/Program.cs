using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 n까지의 합을 구합니다.");
            Console.Write("n의 값 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("1부터 " + n + "까지의 합은 " + sum + "입니다.");
        }
    }
}

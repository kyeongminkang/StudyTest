using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 n까지의 합을 구합니다.");
            Console.Write("n의 값 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i=0; i<=n; i++)
            {
                sum += i;
            }

            Console.WriteLine("1부터 " + n + "까지의 합은 " + sum + "입니다.");
        }
    }
}

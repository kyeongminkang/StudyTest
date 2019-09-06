using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starpira
{
    class Program
    {
        static void spira(int n)
        {
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = i; j <= (n - 1) * 2 + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= (i - 1) * 2 + 1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (i - 1) * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("몇 단 피라미드를 출력할까요 ? ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //spira(n);
            Console.WriteLine("피라미드 모양 만들기");

            int n;

            do
            {
                Console.Write("단 수 : ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n <= 0);

            spira(n);
        }
    }
}

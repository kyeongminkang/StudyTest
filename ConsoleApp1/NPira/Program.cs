using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPira
{
    class Program
    {
        static void npira(int n)
        {
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= (i - 1) * 2 + 1; j++)
            //    {
            //        Console.Write(i);
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
                    Console.Write(i % 10);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("피라미드 모양 만들기");

            int n;

            do
            {
                Console.Write("단 수 : ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n <= 0);

            npira(n);
        }
    }
}

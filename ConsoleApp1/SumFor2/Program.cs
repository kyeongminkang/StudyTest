using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(i + " + ");
            //    sum += i;
            //}
            //sum += n;
            //Console.WriteLine(n + " = " + sum);

            for (int i = 1; i<=n; i++)
            {
                if (i < n)
                {
                    Console.Write(i + " + ");
                }else
                {
                    Console.Write(i);
                }

                sum += i;
            }

            Console.Write(" = " + sum);

        }
    }
}

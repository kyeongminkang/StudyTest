using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("왼쪽 아래가 직각인 이등변 삼각형을 출력합니다.");
            int n;

            do
            {
                Console.WriteLine("몇 단 삼각형입니까? : ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n <= 0);

            for (int i = 1; i<= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

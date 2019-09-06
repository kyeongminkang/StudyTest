using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형을 출력합니다.");
            Console.Write("단 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");              
                }
                Console.WriteLine();
            }            
        }
    }
}
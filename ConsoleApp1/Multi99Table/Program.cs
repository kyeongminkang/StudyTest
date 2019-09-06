using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi99Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("곱셈표 만들기");

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,3:D} ", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}

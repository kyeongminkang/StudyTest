using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add99Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("  |");

            for (int n = 1; n <= 9; n++)
            {
                Console.Write("{0,3:D}", n);
            }
            Console.WriteLine();
            Console.WriteLine("--+----------------------------");
            for (int i = 1; i <= 9; i++)
            {

                Console.Write("{0,3:D}", i + "|");

                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,3:D}", i + j);
                }

                Console.WriteLine();
            }
        }
    }
}

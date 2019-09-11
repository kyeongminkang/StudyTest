using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenB
{
    class Program
    {
        static int[] pos = new int[8];

        static void print()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{pos[i],2}");
            }
            Console.WriteLine();
        }

        static void set(int i)
        {
            for (int j = 0; j < 8; j++)
            {
                pos[i] = j;
                if (i == 7)
                {
                    print();
                }
                else
                {
                    set(1 + i);
                }
            }
        }

        static void Main(string[] args)
        {
            set(0);
        }
    }
}

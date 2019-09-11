using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenBB
{
    class Program
    {
        static bool[] flag = new bool[8];
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
                if (flag[j] == false)
                {
                    pos[i] = j;
                    if (i == 7)
                    {
                        print();
                    }
                    else
                    {
                        flag[j] = true;
                        set(1 + i);
                        flag[j] = false;
                    }
                }
               
            }
        }

        static void Main(string[] args)
        {
            set(0);
        }
    }
}

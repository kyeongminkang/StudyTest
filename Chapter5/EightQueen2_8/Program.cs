using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueen2_8
{
    class Program
    {
        static bool[] flag_a = new bool[8];
        static bool[] flag_b = new bool[15];
        static bool[] flag_c = new bool[15];

        static int[] pos = new int[8];

        static void print()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    Console.Write("{0}",j == pos[i] ? "■" : "□");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }

        static void set(int i)
        {
            for (int j = 0; j < 8; j++)
            {
                if (flag_a[j] == false && flag_b[i + j] == false && flag_c[i - j + 7] == false)
                {
                    pos[i] = j;
                    if (i == 7)
                        print();
                    else
                    {
                        flag_a[j] = flag_b[i + j] = flag_c[i - j + 7] = true;
                        set(i + 1);
                        flag_a[j] = flag_b[i + j] = flag_c[i - j + 7] = false;
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

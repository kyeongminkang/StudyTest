using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[2, 4];

            x[0, 1] = 37;
            x[0, 3] = 54;
            x[1, 2] = 65;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("x[" + i + "," + j + "] = " + x[i, j]);
                }
            }
        }
    }
}

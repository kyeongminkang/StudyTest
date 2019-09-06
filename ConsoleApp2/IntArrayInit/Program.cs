using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArrayInit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }
        }
    }
}

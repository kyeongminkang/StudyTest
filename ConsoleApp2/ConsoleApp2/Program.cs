using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            a[1] = 37;
            a[2] = 51;
            a[4] = a[1] * 2;

            for (int i=0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }
        }
    }
}

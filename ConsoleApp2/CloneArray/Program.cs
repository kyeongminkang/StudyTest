using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = (int[])a.Clone();
            var c= a.Clone();
            if (c is int[])
                b = c as int[];

            //int[] b = a.clone(); 

            b[3] = 0;

            Console.Write("a = ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.Write("\nb = ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }

        }
    }
}

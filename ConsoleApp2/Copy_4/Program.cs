using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_4
{
    class Program
    {

        static void copy(int[]a, int[] b)
        {
            int num = a.Length <= b.Length ? a.Length : b.Length;
            for (int i=0; i<num; i++)
            {
                a[i] = b[i];
            }       
        }

        static void Main(string[] args)
        {
            Console.Write("a 요솟 수 : ");
            int na = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[na];
            for (int i=0; i<na; i++)
            {
                Console.Write("a[" + i + "] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write("b 요솟 수 : ");
            int nb = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[nb];
            for (int i = 0; i < nb; i++)
            {
                Console.Write("b[" + i + "] : ");
                b[i] = Convert.ToInt32(Console.ReadLine());

            }

            copy(a, b);

            for (int i = 0; i < na; i++)
            {
                Console.WriteLine("a[" + i + "] : " + a[i]);
            }

        }
    }
}

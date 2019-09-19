using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerageArray
{
    class Program
    {

        static void merge(int[]a, int na, int[]b, int nb, int[] c)
        {
            int pa = 0;
            int pb = 0;
            int pc = 0;

            while(pa < na && pb < nb)
            {
                c[pc++] = (a[pa] <= b[pb]) ? a[pa++] : b[pb++];
            }

            while(pa < na)
            {
                c[pc++] = a[pa++];
            }

            while(pb < nb)
            {
                c[pc++] = b[pb++];
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 8, 11, 13 };
            int[] b = { 1, 2, 3, 4, 9, 16, 21};

            int[] c = new int[13];

            Console.WriteLine("두 배열의 병합");

            merge(a, a.Length, b, b.Length, c);

            Console.WriteLine("배열 a와 b를 병합하여 배열 c에 저장하였습니다.");
            Console.WriteLine("배열 a : ");
            for (int i=0; i<a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }

            Console.WriteLine("배열 b : ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("b[" + i + "] = " + b[i]);
            }

            Console.WriteLine("배열 c : ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("c[" + i + "] = " + c[i]);
            }



        }
    }
}

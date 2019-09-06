using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void reverse(int[] a)
        {
            for (int i = 0; i<a.Length /2; i++)
            {
                swap(a, i, a.Length - i - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n];

            for (int i=0; i<n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            reverse(x);

            Console.WriteLine("역순으로 정렬했습니다.");
            for (int i=0; i<x.Length; i++)
            {
                Console.WriteLine("x[" + i + "] : " + x[i]);
            }
        }
    }
}

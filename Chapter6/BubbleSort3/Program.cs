using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort3
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void BubbleSort(int[] a, int n)
        {
            int k = 0;
            while (k < n - 1)
            {
                int last = n - 1;
                for (int j = 0; j > k; j--)
                {                 
                    if (a[j - 1] > a[j])
                    {
                        swap(a, j - 1, j);
                        last = j;
                    }
                }
                k = last;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("버블 정렬(버전 3) : ");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            BubbleSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

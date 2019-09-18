using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void quickSort(int[] a, int left, int right)
        {
            int pl = left;
            int pr = right;
            int x = a[(pl + pr) / 2];

            Console.Write($"a[{left}] ~ a[{right}] : {{ ");
            for (int i = left; i < right; i++)
            {
                Console.Write($"{a[i]}, ");
            }
            Console.Write($"{a[right]} }}\n");

            do
            {
                while (a[pl] < x) pl++;
                while (a[pr] > x) pr--;
                if (pl <= pr)
                {
                    swap(a, pl++, pr--);
                }
            } while (pl <= pr);

            if (left < pr)
                quickSort(a, left, pr);
            if (right > pl)
                quickSort(a, pl, right);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            quickSort(x, 0, n-1);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

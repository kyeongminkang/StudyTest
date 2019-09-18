using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partition
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void partition(int[] a, int n)
        {
            int pl = 0;
            int pr = n - 1;
            int x = a[n / 2];

            do
            {
                while (a[pl] < x) pl++;
                while (a[pr] > x) pr--;
                if (pl <= pr)
                {
                    swap(a, pl++, pr--);
                }
            } while (pl <= pr);

            Console.WriteLine("피벗의 값은 " + x + "입니다.");

            Console.WriteLine("피벗 이하의 그룹");
            for (int i = 0; i <= pl - 1; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            if (pl > pr + 1)
            {
                Console.WriteLine("피벗과 일치하는 그룹");
                for (int i = pr + 1; i <= pl - 1; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("피벗 이상의 그룹");
            for (int i = pr + 1; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("배열을 나눕니다.");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            partition(x, n);

        }
    }
}

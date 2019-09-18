using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2Ex_12_2
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
            IntStack lStack = new IntStack(right - left + 1);
            IntStack rStack = new IntStack(right - left + 1);

            lStack.push(left);
            rStack.push(right);

            while (lStack.isEmpty() != true)
            {
                int pl = left = lStack.pop();
                int pr = right = rStack.pop();
                int x = a[(left + right) / 2];

                do
                {
                    while (a[pl] < x) pl++;
                    while (a[pr] > x) pr--;
                    if (pl <= pr)
                    {
                        swap(a, pl++, pr--);
                    }

                } while (pl <= pr);
                if (pr-left < right - pl)
                {
                    int temp;
                    temp = left;
                    left = pl;
                    pl = temp;
                    temp = right;
                    right = pr;
                    pr = temp;
                }

                if (left < pr)
                {
                    lStack.push(left);
                    rStack.push(pr);
                }
                if (pl < right)
                {
                    lStack.push(pl);
                    rStack.push(right);
                }

            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬(비재귀)");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            quickSort(x, 0, n - 1);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

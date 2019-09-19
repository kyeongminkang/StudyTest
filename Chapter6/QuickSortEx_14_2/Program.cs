using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2Ex_14_2
{
    class Program
    {

        static int med3(int a, int b, int c)
        {
            if (a >= b)
                if (b >= c)
                {
                    return b;
                }
                else if (a <= c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            else if (a > c)
                return a;
            else if (b > c)
                return c;
            else
                return b;
        }
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void insertionSort(int[] a, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int tmp = a[i];
                int j;
                for (j = i; j > 0 && a[j - 1] > tmp; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = tmp;
            }
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


                if (right - left < 9)
                {
                    insertionSort(a, left, right);
                }
                else
                {

                    do
                    {
                        int x = med3(a[pl], a[(left + right) / 2], a[pr]);

                        while (a[pl] < x) pl++;
                        while (a[pr] > x) pr--;
                        if (pl <= pr)
                        {
                            swap(a, pl++, pr--);
                        }

                    } while (pl <= pr);
                    if (pr - left < right - pl)
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

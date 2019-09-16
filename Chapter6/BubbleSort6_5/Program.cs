using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort6_5
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void bubbleSort(int[] a, int n)
        {
            int left = 0;
            int right = n - 1;

            int last = right;

            while (left < right)
            {
                for (int j = right; j > left; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        swap(a, j - 1, j);
                        last = j;
                    }

                }
                left = last;

                for (int j = left; j < right; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);
                        left = j;
                    }
                }
                right = last;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("버블 정렬(양방향 정렬) : ");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            bubbleSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }

        }
    }
}

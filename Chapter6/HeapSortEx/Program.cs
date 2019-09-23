using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortEx
{
    class Program
    {

        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void downHeap(int[] a, int left, int right)
        {
            int temp = a[left];
            int child;
            int parent;

            for (parent = left; parent < (right + 1) / 2; parent = child)
            {
                int cl = parent * 2 + 1;
                int cr = cl + 1;
                child = (cr <= right && a[cr] > a[cl]) ? cr : cl;
                if (temp >= a[child])
                {
                    break;
                }
                a[parent] = a[child];

            }
            a[parent] = temp;
        }

        static void heapSort(int[] a, int n)
        {
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                downHeap(a, i, n - 1);
            }
            for (int i = n - 1; i > 0; i--)
            {
                swap(a, 0, i);
                downHeap(a, 0, i - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("힙정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            heapSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

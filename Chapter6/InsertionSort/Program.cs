using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void insertionSort(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j;
                int tmp = a[i];
                for (j = i; j > 0 && a[j - 1] > tmp; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = tmp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("단순 삽입 정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            insertionSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

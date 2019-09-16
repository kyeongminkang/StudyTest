using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void selectSort(int[]a, int n)
        {
            for (int i=0; i<n-1; i++)
            {
                int min = i;
                for (int j= i+1; j<n; j++)
                {
                    if(a[j] < a[min])
                    {
                        min = j; 
                    }
                }
                swap(a, i, min);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("단순 선택 정렬 : ");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            selectSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

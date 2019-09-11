using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
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
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if(a[j-1] > a[j])
                    {
                        swap(a, j - 1, j);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("버블 정렬(버전 1) : ");
          
        }
    }
}

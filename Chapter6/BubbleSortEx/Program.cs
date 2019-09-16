using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortEx
{
    class Program
    {

        static void swap(int[]a, int idx1, int idx2)
        {
            int temp = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = temp;
        }

        static void bubbleSort(int[]x, int n)
        {
            for (int i=0; i<n; i++)
            {
                for (int j = n; j<i; j--)
                {
                    if (x[j] < x[j - 1])
                    {
                        swap(x, j - 1, j);
                    }
                        
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("버블 정렬(버전 1) : ");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortEx_7
{
    class Program
    {
        static void insertionSort(int[] a, int n)
        {

            for (int i = 2; i < n; i++)
            {
                int tmp = a[0] = a[i];
                int j = i;
                for (; a[j - 1] > tmp; j--)
                {
                    a[j] = a[j - 1];

                }

                if (j > 0)
                {
                    a[j] = tmp;
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("단순 삽입 정렬 수정");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n + 1];


            for (int i = 1; i <= n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            insertionSort(x, n + 1);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

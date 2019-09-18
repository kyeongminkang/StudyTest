using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSrot2Ex_9_2
{
    class Program
    {
        static int shellSort(int[] a, int n)
        {
            int count = 0;
            int h;
            for (h = 1; h < n / 9; h = h * 3 + 1) ;
            for (; h > 0; h /= 3)
            {
                for (int i = h; i < n; i++)
                {
                    int j;
                    int tmp = a[i];
                    for (j = i - h; j >= 0 && a[j] > tmp; j -= h)
                    {
                        a[j + h] = a[j];
                        count++;
                    }
                    a[j + h] = tmp;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("셀 정렬(버전2)");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = shellSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }

            Console.WriteLine("요소의 옮김횟수는 " + count + "회 입니당.");
        }
    }
}

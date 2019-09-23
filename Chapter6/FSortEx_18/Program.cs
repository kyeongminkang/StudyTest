using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSortEx_18
{
    class Program
    {

        static void fSort(int[] a, int n, int max)
        {
            int[] f = new int[max + 1];
            int[] b = new int[n];
            Console.WriteLine("제 1단계");
            for (int i = 0; i < n; i++)
                
            {
                for (int j=0; j<max; j++)
                {
                    Console.Write($"{f[j]} ");
                }
                Console.WriteLine();

                f[a[i]]++;
               
            }
            for (int k = 0; k<= max; k++)
            {
                Console.Write($"{f[k]} ");
            }
            Console.WriteLine();

            Console.WriteLine("제 2단계");
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    Console.Write($"{f[j]} ");
                }
                Console.WriteLine();
                f[i] += f[i - 1];
            }
            for (int k = 0; k <= max; k++)
            {
                Console.Write($"{f[k]} ");
            }
            Console.WriteLine();

            Console.WriteLine("제 3단계");
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{b[j]} ");
                }
                Console.WriteLine();
                b[--f[a[i]]] = a[i];
            }
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{b[k]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++) a[i] = b[i];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("도수 정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = x[0];
            for (int i = 1; i < n; i++)
            {
                if (x[i] > max)
                    max = x[i];
            }

            fSort(x, n, max);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

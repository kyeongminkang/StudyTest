using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSort2_19
{
    class Program
    {

        static void fSort(int[] a, int n, int min, int max)
        {
            int[] f = new int[max - min + 2];
            int[] b = new int[n];

            for (int i = 0; i < n; i++) f[a[i] - min]++;
            for (int i = 1; i <= max - min + 1; i++) f[i] += f[i - 1];
            for (int i = n - 1; i >= 0; i--) b[--f[a[i] - min]] = a[i];
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

            int min = x[0];
            for (int i = 1; i < n; i++)
                if (x[i] < min)
                    min = x[i];

            fSort(x, n, min, max);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsort
{
    class Program
    {

        static void fSort(int[]a, int n, int max)
        {
            int[] f = new int[max + 1];
            int[] b = new int[n];

            for (int i = 0; i < n; i++) f[a[i]]++;
            for (int i = 1; i <= max; i++) f[i] += f[i - 1];
            for (int i = n - 1; i >= 0; i--) b[--f[a[i]]] = a[i];
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
            for(int i = 1; i < n; i++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf_03
{
    class Program
    {
        static int sumOf(int[] a)
        {
            int sum = 0;
            for (int i=0; i<a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("요솟 수를 정해주세요");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("요솟값을 입력해주세요");

            int[] x = new int[n];
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(sumOf(x));
        }
    }
}

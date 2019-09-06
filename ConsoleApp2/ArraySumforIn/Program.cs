using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumforIn
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 1.0, 2.0, 3.0, 4.0, 5.0 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }

            double sum = 0;

            foreach (double i in a)
            {
                sum += i;
            }

            Console.WriteLine("모든 요소의 합은 " + sum + "입니다.");
        }
    }
}

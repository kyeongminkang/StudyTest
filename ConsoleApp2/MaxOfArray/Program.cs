using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfArray
{
    class Program
    {
        static int maxOf(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("키의 최댓값을 구합니다. ");
            Console.Write("사람의 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] height = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("height[" + i + "] : ");
                height[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("최댓값은 "+maxOf(height)+"입니다.");

        }
    }
}

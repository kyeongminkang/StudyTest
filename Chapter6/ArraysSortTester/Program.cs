using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSortTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이진 검색으로 단순 삽입 정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(x);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

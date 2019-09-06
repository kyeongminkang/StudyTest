using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqSearch2_2
{
    class Program
    {
        static int seqSearch2(int[] a, int n, int key)
        {
            Console.Write("   |");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i,4:D}");
            }
            Console.WriteLine();
            Console.Write("---+");
            for (int i = 0; i < n * 4; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            string star = "*";
            for (int i = 0; i < n; i++)
            {
                Console.Write("   |");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0,4}", "");
                }
                Console.WriteLine("{0,4}", star);

                Console.Write(i+"  |");


                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[j],4:D}");
                }
                Console.WriteLine();
                Console.WriteLine("   |");


                if (a[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("검색할 값 : ");
            int key = Convert.ToInt32(Console.ReadLine());

            int idx = seqSearch2(a, n, key);

            if (idx == -1)
            {
                Console.WriteLine("그 값의 요소가 없습니다.");
            }
            else
            {
                Console.WriteLine(key + "는 x[" + idx + "]에 있습니다.");
            }
        }
    }
}

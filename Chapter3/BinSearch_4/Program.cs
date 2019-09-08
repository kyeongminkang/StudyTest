using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch_4
{
    class Program
    {
        public static int binSearch4(int[]a, int n, int key)
        {
            int pl = 0;
            int pr = n - 1;
            int pc = (pl + pr) / 2;

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
                Console.Write("  |");
                for (int j=0; j<n; j++)
                {
                    
                    Console.Write($"{a[j],4:D}");
                   
                }
                Console.WriteLine();



                //Console.Write("   |");
                //for (int j = 0; j < i; j++)
                //{
                //    Console.Write("{0,4}", "");
                //}
                //Console.WriteLine("{0,4}", star);

            //제발 니가 됐으면 좋겠어.....
            }

            for (int i=0; i<n; i++)
            {      
                if (a[i] == key)
                {
                    return i;
                }else if (pc < key)
                {
                    pl = pc + 1;
                }else
                {
                    pr = pc - 1;
                }
            }

            

            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("오름차순으로 입력하세요");

            Console.Write("a[0] : ");
            a[0] = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                do
                {
                    Console.Write("a[" + i + "] : ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                } while (a[i] < a[i - 1]);
            }

            Console.Write("검색할 값 : ");
            int key = Convert.ToInt32(Console.ReadLine());

            int idx = binSearch4(a, n, key);

            if (idx == -1)
            {
                Console.WriteLine("그 값의 요소가 없습니다. ");
            }
            else
            {
                Console.WriteLine(key + "는 a[" + idx + "]에 있습니다.");
            }
        }
    }
}

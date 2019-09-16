using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BininsertionSort_8
{
    class Program
    {

        static void BininsertionSort(int[] a, int n)
        {



            for (int i = 1; i < n; i++)
            {
                int pl = 0;
                int pr = i - 1;
                int pc;
                int key = a[i];
                int pd;

                do
                {
                    pc = (pl + pr) / 2;
                    if (a[pc] == key)
                    {
                        break;
                    }
                    else if (a[pc] < key)
                    {
                        pl = pc + 1;
                    }
                    else
                    {
                        pr = pc - 1;
                    }
                } while (pl <= pr);

                pd = (pl <= pr) ? pc + 1 : pr + 1;

                for (int j = i; j > pd; j--)
                    a[j] = a[j - 1];
                a[pd] = key;

            }
        }

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

            BininsertionSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

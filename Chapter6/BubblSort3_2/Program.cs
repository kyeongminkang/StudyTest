using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblSort3_2
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void bubbleSort(int[] a, int n)
        {

            int cnt1 = 0; //비교
            int cnt2 = 0; //교환


            for (int i = 0; i < n - 1; i++)
            {
              
                Console.WriteLine("패스 " + (i + 1) + ":");

                for (int j = n - 1; j > i; j--)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        Console.Write("{0} {1}", a[k], (k != j - 1) ? ' ' : (a[j - 1] > a[j]) ? '+' : '-');
                    }
                    Console.Write($"{a[n-1],3}");
                    Console.WriteLine();

                    cnt1++;

                    if (a[j - 1] > a[j])
                    {
                        swap(a, j - 1, j);
                        cnt2++;

                    }
                    //Console.Write(a[k] + " ");
                }

                for (int k = 0; k < n; k++)
                {
                    Console.Write(" " + a[k] + " ");
                }
                
                Console.WriteLine();
              
            }
            Console.WriteLine("비교를 " + cnt1 + "회 했습니다.");
            Console.WriteLine("교환을 " + cnt2 + "회 했습니다.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("버블 정렬(버전 1) : ");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            bubbleSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }

        }
    }
}

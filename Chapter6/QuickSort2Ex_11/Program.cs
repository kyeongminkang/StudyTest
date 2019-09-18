using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2Ex_11
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void quickSort(int[] a, int left, int right)
        {
            IntStack lStack = new IntStack(right - left + 1);
            IntStack rStack = new IntStack(right - left + 1);

            lStack.push(left);
            rStack.push(right);
            Console.WriteLine($"{a[left]}~{a[right]}를 분할하는 문제를 스택에 푸시합니다.");
            Console.Write("Lstack");
            lStack.dump();
            Console.Write("Rstack");
            rStack.dump();

            while (lStack.isEmpty() != true)
            {
                int pl = left = lStack.pop();
                int pr = right = rStack.pop();
                int x = a[(left + right) / 2];


                Console.WriteLine($"스텍에서 분할하는 문제를 꺼냈습니다. {a[left]}~{a[right]}를 분할합니다.");
                do
                {
                    while (a[pl] < x) pl++;
                    while (a[pr] > x) pr--;
                    if (pl <= pr)
                    {
                        swap(a, pl++, pr--);
                    }

                } while (pl <= pr);

                if (left < pr)
                {
                    lStack.push(left);
                    rStack.push(pr);
                    Console.WriteLine($"{a[left]}~{a[pr]}를 분할하는 문제를 스택에 푸시합니다.");
                    Console.Write("Lstack");
                    lStack.dump();
                    Console.Write("Rstack");
                    rStack.dump();

                }
                if (pl < right)
                {
                    lStack.push(pl);
                    rStack.push(right);
                    Console.WriteLine($"{a[pl]}~{a[right]}를 분할하는 문제를 스택에 푸시합니다.");
                    Console.Write("Lstack");
                    lStack.dump();
                    Console.Write("Rstack");
                    rStack.dump();
                }

            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬(비재귀)");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            quickSort(x, 0, n - 1);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

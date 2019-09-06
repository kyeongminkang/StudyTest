using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray2_02
{
    class Program
    {
        //static void swap(int[] a, int idx1, int idx2)
        //{
        //    int t = a[idx1];
        //    a[idx1] = a[idx2];
        //    a[idx2] = t;

        //    for (int i = 0; i <a.Length; i++)
        //    {
        //        Console.Write(a[i] + " ");
        //    }

        //}
        static void swap(int[]a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void print(int[] a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void reverse(int[] a)
        {
            print(a);
            for (int i=0; i<a.Length/2; i++)
            {
                Console.WriteLine("a[" + i + "]과" + "a[" + (a.Length-i-1) + "]를 교환합니다.");
                swap(a, i, a.Length - i - 1);
                print(a);
            }
          
        }



        static void Main(string[] args)
        {
            //int[] a = { 5, 10, 73, 2, -5, 42 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("a[0]과 a[5]를 교환합니다.");
            //swap(a, 0, 5);
            //Console.WriteLine("a[1]과 a[4]를 교환합니다.");
            //swap(a, 1, 4);
            //Console.WriteLine("a[2]과 a[3]를 교환합니다.");
            //swap(a, 2, 3);
            //Console.WriteLine("역순 정렬을 마쳤습니다.");

            Console.WriteLine("요솟 수를 정해주세요");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n];
            for (int i=0; i<x.Length; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            reverse(x);

            Console.WriteLine("역순 정렬을 마쳤습니다.");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);
            }


        }
    }
}

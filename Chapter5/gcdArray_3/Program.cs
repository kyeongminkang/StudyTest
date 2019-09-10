using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcdArray_3
{
    class Program
    {

        static int gcd(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;

            }
            return x;
        }

        //static int gcdArray(int[] a)
        //{
            
        //    int number = 0;

        //    for (int i = a.Min(); i > 0; i--)
        //    {
        //        int count = 0;
        //        for (int j = 0; j<a.Length; j++)
        //        {
        //            if (a[j] % i == 0)
        //            {
        //                count++;
        //            }                      
        //        }

        //        if (count == a.Count())
        //        {
        //            number = i;

        //            break;
        //        }
                    
        //    }

        //    return number;

        //}

        static int gcdArray(int[] a, int start, int no)
        {
            if (no == 1)
                return a[start];
            else if (no == 2)
                return gcd(a[start], a[start + 1]);
            else
                return gcd(a[start], gcdArray(a, start + 1, no - 1));
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("모든 요소의 최대공약수를 구합니다.");
            //Console.Write("몇 개의 요소를 구하시겠습니까 ? ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] a = new int[n];

            //for (int i=0; i<a.Length; i++)
            //{
            //    Console.Write("정수를 입력하세요. : ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    a[i] = x;

            //}

            //Console.WriteLine("최대공약수는 " + gcdArray(a) + "입니다.");

            Console.Write("정수 몇 개의 최대 공약수를 구할까요 ? : ");
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 1);

            int[] x = new int[num];

            for (int i=0; i<num; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("최대공약수는 " + gcdArray(x, 0, num) + "입니다.");
        }
    }
}

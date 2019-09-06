using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf
{
    class Program
    {

        static int sumof(int a, int b)
        {
            //int sum = 0;
            //if (a >= b)
            //{
            //    for (int i = b; i <= a; i++)
            //    {
            //        sum += i;
            //    }
            //}
            //else
            //{
            //    for (int i = a; i <= b; i++)
            //    {
            //        sum += i;
            //    }
            //}

            //return sum;
            int min;
            int max;

            if (a < b)
            {
                min = a;
                max = b;
            } else
            {
                min = b;
                max = a;
            }

            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개를 입력하세요");
            Console.Write("a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b : ");
            int b = Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine(a+"와 " + b +"사이의 모든 정수의 합은 "+sumof(a, b)+"입니다." );
        }
    }
}

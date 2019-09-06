using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b-a의 값을 구합니다.");
            //int a;
            //int b;

            //Console.WriteLine("정수 2개를 입력하세요.");
            //Console.Write("a : ");
            //a = Convert.ToInt32(Console.ReadLine());

            //do
            //{   
            //    Console.Write("b : ");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("a보다 큰 값을 입력하세요");
            //} while (a >= b);

            //Console.WriteLine(b + " - " + a + " 의 값은 " + (b - a) + "입니다.");

            Console.WriteLine("정수 2개를 입력하세요.");
            Console.Write("a : ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = 0;
            while (true)
            {
                Console.Write("b : ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b > a)
                    break;
                Console.WriteLine("a보다 큰 값을 입력하세요");
            }

            Console.WriteLine(b + " - " + a + " 의 값은 " + (b - a) + "입니다.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("세 정수의 최댓값을 구하세요");
            Console.Write("1. a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.Write("2. b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            Console.Write("3. c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c);

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"최댓값은 {max} 입니다.");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurX1
{
    class Program
    {
        static void recur(int n)
        {
            while (n > 0)
            {
                recur(n - 1);
                Console.WriteLine(n);
                n = n - 2;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");

            int x = Convert.ToInt32(Console.ReadLine());
            recur(x);
        }
    }
}

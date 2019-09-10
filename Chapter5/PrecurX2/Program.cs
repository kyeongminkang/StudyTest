using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecurX2
{
    class Program
    {
        static void recur(int n)
        {
            IntStack s = new IntStack(n);

            while (true)
            {
                if (n > 0)
                {
                    s.push(n);
                    n = n - 1;
                    continue;
                }
                if (s.isEmpty() != true)
                {
                    n = s.pop();
                    Console.WriteLine(n);
                    n = n - 2;
                    continue;
                }
                break;
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

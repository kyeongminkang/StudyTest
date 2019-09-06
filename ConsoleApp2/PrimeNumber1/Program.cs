using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int n= 2; n<= 1000; n++)
            {
                int i;
                for (i = 2; i<n; i++)
                {
                    counter++;
                    if(n % i == 0)
                    {
                        break;
                    }
                }
                if (n == i)
                {
                    Console.Write(n);
                }
                Console.WriteLine("나눗셈을 수행한 횟수 : " + counter);
            }
        }
    }
}

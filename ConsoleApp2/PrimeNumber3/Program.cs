using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int ptr = 0;
            int[] prime = new int[500];

            prime[ptr++] = 2;
            prime[ptr++] = 3;

            for (int n = 5; n <= 1000; n += 2)
            {
                Boolean flag = false;
                for (int i=0; prime[i]*prime[i] <= n; i++)
                {
                    counter += 2;
                    if (n % prime[i] == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    prime[ptr++] = n;
                    counter++;
                }
            }

            for (int i=0; i<ptr; i++)
            {
                Console.WriteLine(prime[i]);
            }

            Console.WriteLine("곱셈과 나눗셈을 수행한 횟수 : " + counter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int ptr = 0;
            int[] prime = new int[500];

            prime[ptr++] = 2;

            for(int n = 3; n<=1000; n += 2)
            {
                int i;
                for (i=1; i<ptr; i++)
                {
                    counter++;
                    if(n%prime[i] == 0)
                    {
                        break;
                    }
                }
                if (ptr == i)
                {
                    prime[ptr++] = n;
                }
            }

            for (int i=0; i<=ptr; i++)
            {
                Console.WriteLine(prime[i]);
            }

            Console.WriteLine("나눗셈을 수행한 횟수 : " + counter);
        }
    }
}

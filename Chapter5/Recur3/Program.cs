
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recur3
{
    class Program
    {

        static void recur3(int n)
        {
            int[] nstk = new int[100];
            int[] sstk = new int[100];
            int ptr = -1;
            int sw = 0;

            while (true)
            {
                if (n > 0)
                {
                    ptr++;
                    nstk[ptr] = n;
                    sstk[ptr] = sw;

                    if (sw == 0)
                    {
                        n = n - 1;
                    }

                    else if (sw == 1)
                    {
                        n = n - 2;
                        sw = 0;
                    }
                    continue;
                }
                do
                {
                    n = nstk[ptr];
                    sw = sstk[ptr--] + 1;

                    if (sw == 2)
                    {
                        Console.WriteLine(n);
                        if (ptr < 0)
                        {
                            return;
                        }
                    }
                } while (sw == 2);
            }
           
            

        }
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");

            int x = Convert.ToInt32(Console.ReadLine());
            recur3(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNElements
{
    class Program
    {


        static void Main(string[] args)
        {
            const int N = 10;
            int[] a = new int[N];
            int cnt = 0;
            int retry;

            Console.Write("정수를 입력하세요 : ");

            do
            {
                Console.Write($"{cnt + 1}번째 정수 : ");
                a[cnt++ % N] = Convert.ToInt32(Console.ReadLine());

                Console.Write("계속 할까요? (예.1/아니오.0) : ");
                retry = Convert.ToInt32(Console.ReadLine());
            } while (retry == 1);

            int i = cnt - N;
            if (i < 0) i = 0;

            for (; i < cnt; i++)
                Console.Write($"{i + 1}번째 정수 = {a[i % N]}"+" ");
        }
    }
}

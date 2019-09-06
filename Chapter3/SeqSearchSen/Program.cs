using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqSearchSen
{
    class Program
    {
        public static int seqSearchSen(int[]a, int n, int key)
        {
            int i = 0;

            a[n] = key;

            while (true)
            {
                if (a[i] == key)
                    break;
                i++;
            }
            return i == n ? -1 : i;
        }

        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n+1];

            for (int i=0; i<n; i++)
            {
                Console.Write("a[" + i + "] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("검색할 값 : ");
            int key = Convert.ToInt32(Console.ReadLine());

            int idx = seqSearchSen(a, n, key);

            if (idx == -1)
            {
                Console.WriteLine("그 값의 요소가 없습니다.");
            }
            else
            {
                Console.WriteLine(key + "는 x[" + idx + "]에 있습니다.");
            }
        }
    }
}

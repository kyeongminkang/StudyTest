using System;

namespace binSearchX
{
    class Program
    {
        public static int binSearchX_5(int[]a, int n, int key)
        {
            int pl = 0;
            int pr = n - 1;

            do
            {
                int pc = (pl + pr) / 2;
                if (a[pc] == key)
                {
                    return pc;
                    break;
                }
                else if (a[pc] < key)
                {
                    pl = pc + 1;
                }
                else
                {
                    pr = pr - 1;
                }
            } while (pl <= pr);

            return -1;

        }
        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("오름차순으로 입력하세요");

            Console.Write("a[0] : ");
            a[0] = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                do
                {
                    Console.Write("a[" + i + "] : ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                } while (a[i] < a[i - 1]);
            }

            Console.Write("검색할 값 : ");
            int key = Convert.ToInt32(Console.ReadLine());

            int idx = binSearch(a, n, key);

            if (idx == -1)
            {
                Console.WriteLine("그 값의 요소가 없습니다. ");
            }
            else
            {
                Console.WriteLine(key + "는 a[" + idx + "]에 있습니다.");
            }
        }
    }
}

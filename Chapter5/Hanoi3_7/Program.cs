using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi3_7
{
    class Program
    {
        static void move(int no, int x, int y)
        {

            int[] xstk = new int[100];
            int[] ystk = new int[100];
            int[] sstk = new int[100];
            int ptr = 0;
            int sw = 0;

            while (true)
            {
                if(sw == 0 && no > 1)
                {
                    xstk[ptr] = x;
                    ystk[ptr] = y;
                    sstk[ptr] = sw;
                    ptr++;
                    no = no - 1;
                    y = 6 - x - y;

                    continue;
                }
                Console.WriteLine($"{no}를 {x}기둥에서 {y}기둥으로 옮김.");

                if(sw == 1 && no > 1)
                {
                    xstk[ptr] = x;
                    ystk[ptr] = y;
                    sstk[ptr] = sw;
                    ptr++;
                    no = no - 1;
                    x = 6 - x - y;
                    if (++sw == 2)
                    {
                        sw = 0;
                    }
                    continue;

                }
                do
                {
                    if (ptr-- == 0)
                    {
                        return;
                    }
                    x = xstk[ptr];
                    y = ystk[ptr];
                    sw = sstk[ptr] + 1;
                    no++;
                } while (sw == 2);
            }
            


            //if (no > 1)
            //    move(no - 1, x, 6 - x - y);

            //Console.WriteLine("원반[" + no + "]을 " + x + "기둥에서 " + y + "기둥으로 옮김.");

            //if (no > 1)
            //    move(no - 1, 6 - x - y, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("하노이의 탑");
            Console.Write("원반 개수 : ");

            int n = Convert.ToInt32(Console.ReadLine());

            move(n, 1, 3);
        }
    }
}

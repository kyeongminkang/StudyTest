using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi2_6
{
    class Program
    {

        static string[] name = { "A기둥", "B기둥", "C기둥" };


        static void move(int no, int x, int y)
        {
            if (no > 1)
                move(no - 1, x, 6 - x - y);

            //char[] arr = new char[27];
            //for (int i = 65; i <= 90; i++)
            //{
            //    arr[i - 65] = (char)i;

            //}

            //Console.WriteLine("원반[" + no + "]을 " + arr[x-1] + "기둥에서 " + arr[y-1] + "기둥으로 옮김.");

            Console.WriteLine("원반[" + no + "]을 " + name[x - 1] + "기둥에서 " + name[y - 1] + "기둥으로 옮김.");

            if (no > 1)
                move(no - 1, 6 - x - y, y);
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

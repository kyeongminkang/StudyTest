using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void move (int no, int x, int y)
        {
            if (no > 1)
                move(no - 1, x, 6 - x - y);

            Console.WriteLine("원반[" + no + "]을 " + x + "기둥에서 " + y + "기둥으로 옮김.");

            if (no > 1)
                move(no - 1, 6 - x - y, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("하노이의 탑");
            Console.Write("원반 개수 : ");

            int n = Convert.ToInt32(Console.ReadLine());

            move(n,1,3);
        }
    }
}

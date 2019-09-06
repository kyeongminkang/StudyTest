using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardConvRev
{
    class Program
    {

        static int cardConvR(int x, int r, char[] d)
        {
            int digits = 0;
            String dchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            do
            {
                d[digits++] = dchar[x % r];
                x /= r;

            } while (x != 0);
            return digits;
        }
        static void Main(string[] args)
        {
            int no;
            int cd;
            int dno;
            int retry;
            char[] cno = new char[32];

            Console.WriteLine("10진수를 기수 변환합니다.");
            do
            {
                do
                {
                    Console.Write("변환하는 음이 아닌 정수 : ");
                    no = Convert.ToInt32(Console.ReadLine());
                } while (no < 0);

                do
                {
                    Console.Write("어떤 진수로 변환할까요?");
                    cd = Convert.ToInt32(Console.ReadLine());
                } while (cd < 2 || cd > 36);

                dno = cardConvR(no, cd, cno);

                Console.Write(cd + "진수로는 ");
                for (int i = dno - 1; i >= 0; i--)
                {
                    Console.Write(cno[i]);
                }
                Console.Write("입니다");

                Console.Write("한 번 더 할까요? (1.예/0.아니오) : ");
                retry = Convert.ToInt32(Console.ReadLine());
            } while (retry == 1);
        }
    }
}

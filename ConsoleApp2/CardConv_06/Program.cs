using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardConv_06
{
    class Program
    {
        static int cardConv(int x, int r, char[] d)
        {
            int digits = 0;
            string dchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            do
            {
                d[digits++] = dchar[x % r];
                x /= r;
            } while (x != 0);

            for (int i = 0; i < digits / 2; i++)
            {
                char temp = d[i];
                d[i] = d[digits - i - 1];
                d[digits - i - 1] = temp;
            }

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

                dno = cardConv(no, cd, cno);

                Console.Write(cd + "진수로는 ");
                for (int i = 0; i < dno; i++)
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

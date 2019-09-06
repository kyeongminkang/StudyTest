using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardConv2_07
{
    class Program
    {
        static int cardConv(int x, int r, char[] d)
        {
            int n = x;
            int digits = 0;
            string dchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine($"{r,3}|{x,5}");
            do
            {
                Console.Write("   +");
                for(int i=0; i<n+2; i++)
                    Console.Write("-");
                Console.WriteLine();

                if (x / r != 0)
                {
                    Console.Write("{0,3}|{1,5}'''{2}", r, x / r, x % r);
                }else
                {
                    Console.Write("{0,3}|{1,5}'''{2}", r, x / r, x % r);
                    
                }
                    d[digits++] = dchar[x % r];
                    x /= r;
                Console.WriteLine();

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
            char[] cno = new char[32];
            Console.WriteLine("10진수를 기수 변환합니다.");

            do
            {
                Console.Write("변환하는 음이 아닌 정수 : ");
                no = Convert.ToInt32(Console.ReadLine());
            } while (no < 0);

            do
            {
                Console.Write("어떤 진수로 변환할까요? (2-36)");
                cd = Convert.ToInt32(Console.ReadLine());

            } while (cd < 2 || cd > 36);


            dno = cardConv(no, cd, cno);

            Console.Write(cd + "진수로는 ");
            for (int i = 0; i < dno; i++)
            {
                Console.Write(cno[i]);
            }
            Console.Write("입니다");

        }
    }
}

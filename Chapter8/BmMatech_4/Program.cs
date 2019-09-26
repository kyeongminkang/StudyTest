using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmMatech_4
{
    class Program
    {
        static int bmMatch(string txt, string pat)
        {
            int pt;
            int pp;
            int txtlen = txt.Length;
            int patlen = pat.Length;
            int[] skip = new int[Char.MaxValue + 1];
            int count = 0;
            int k = -1;

            for (pt = 0; pt <= char.MaxValue; pt++)
                skip[pt] = patlen;
            for (pt = 0; pt < patlen - 1; pt++)
                skip[pat[pt]] = patlen - pt - 1;


            while (pt < txtlen)
            {
                pp = patlen - 1;

                if(k==pt - pp)
                {
                    Console.WriteLine("    ");
                }else
                {
                    Console.Write($" {pt - pp} ");
                }
                for(int i = 0; i < txt.Length; i++)
				Console.Write(txt[i] + " ");
                Console.WriteLine();

                for (int i = 0; i < pt * 2 + 4; i++)
                    Console.Write(" ");
                Console.Write(txt[pt] == pat[pp] ? '+' : '|');
                Console.WriteLine();

                for (int i = 0; i < (pt - pp) * 2 + 4; i++)
                    Console.Write(" ");

                for (int i = 0; i < pat.Length; i++)
                    Console.Write(pat[i] + " ");
                Console.WriteLine();
                Console.WriteLine();
                count++;


                while (txt[pt] == pat[pp])
                {

                    if (pp == 0)
                        return pt;
                    pp--;
                    pt--;

                    if (k == pt - pp)
                    {
                        Console.WriteLine("    ");
                    }
                    else
                    {
                        Console.Write($" {pt - pp} ");
                    }
                    for (int i = 0; i < txt.Length; i++)
                        Console.Write(txt[i] + " ");
                    Console.WriteLine();

                    for (int i = 0; i < pt * 2 + 4; i++)
                        Console.Write(" ");
                    Console.Write(txt[pt] == pat[pp] ? '+' : '|');
                    Console.WriteLine();

                    for (int i = 0; i < (pt - pp) * 2 + 4; i++)
                        Console.Write(" ");

                    for (int i = 0; i < pat.Length; i++)
                        Console.Write(pat[i] + " ");
                    Console.WriteLine();
                    Console.WriteLine();
                    count++;


                }

                pt += skip[txt[pt]];
            }
            return -1;

        }
        static void Main(string[] args)
        {
            Console.Write("텍스트 : ");
            string s1 = Console.ReadLine();

            Console.Write("패턴 : ");
            string s2 = Console.ReadLine();

            int idx = bmMatch(s1, s2);

            if (idx == -1)
            {
                Console.WriteLine("텍스트에 패턴이 없습니다.");

            }
            else
            {
                int len = 0;
                for (int i = 0; i < idx; i++)
                {
                    len += s1.Substring(i, i + 1).Length;

                }
                len += s2.Length;
            }

            Console.WriteLine((idx + 1) + "번쨰 문자부터 일치합니다.");
            Console.WriteLine("텍스트 : " + s1);
            Console.WriteLine($"패턴 : {s2}");
        }
    }
}

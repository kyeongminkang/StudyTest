using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMPmatch_3
{
    class Program
    {
        static int kmpMatch(string txt, string pat)
        {
            int pt = 1;
            int pp = 0;
            int count = 0;
            int k = -1;
            int[] skip = new int[pat.Length + 1];

            Console.WriteLine("skip 테이블 만들기");
            skip[pt] = 0;
            while (pt != pat.Length)
            {
                if (k == pt - pp)
                    Console.Write("    ");
			else {
                    Console.Write($" {pt - pp} ");
                    k = pt - pp;
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
                if (pat[pt] == pat[pp])
                    skip[++pt] = ++pp;
                else if (pp == 0)
                    skip[++pt] = pp;
                else
                    pp = skip[pp];
            }

            Console.WriteLine("검색");
            pt = pp = 0;
            while (pt != txt.Length && pp != pat.Length)
            {
                if (k == pt - pp)
                {
                    Console.Write("    ");
                }else
                {
                    Console.Write($" {pt - pp} ");
                    k = pt - pp;
                }
                for (int i=0; i<txt.Length; i++)
                {
                    Console.Write(txt[i] + " ");
                }
                Console.WriteLine();

                for (int i=0; i<pt*2+4; i++)
                {
                    Console.Write("");
                }
                Console.Write(txt[pt] == pat[pp] ? '+' : '|');
                Console.WriteLine();

                for (int i = 0; i < (pt - pp) * 2 + 4; i++)
                    Console.Write(" ");

                for (int i = 0; i < pat.Length; i++)
                    Console.Write(pat[i] + " ");
                Console.WriteLine();
                Console.WriteLine();
                count++;

                if (txt[pt] == pat[pp])
                {
                    pt++;
                    pp++;
                }
                else if (pp == 0)
                {
                    pt++;
                }
                else
                {
                    pp = skip[pp];
                }
            }

            Console.WriteLine($"비교는 {count}회 입니다.");
            if (pp == pat.Length)
                return pt - pp;

            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("텍스트 : ");
            string s1 = Console.ReadLine();

            Console.Write("패턴 : ");
            string s2 = Console.ReadLine();

            int idx = kmpMatch(s1, s2);

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

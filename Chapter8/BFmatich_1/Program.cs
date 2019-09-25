using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFmatich_1
{
    class Program
    {
        static int bfMatch(string txt, string pat)
        {
            int pt = 0;
            int pp = 0;
            int count = 0;
            int k = -1;

            while (pt != txt.Length && pp != pat.Length)
            {
                if (k == pt - pp)
                {
                    Console.WriteLine("    ");
                }else
                {
                    Console.WriteLine($"{pt - pp:2}");
                }
                for (int i=0; i<txt.Length; i++)
                {
                    Console.Write(txt[i] + " ");
                     
                }
                Console.WriteLine();

                for(int i= 0; i< pt *2+4; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(txt[pt] == pat[pp] ? "+" : "|");
                Console.WriteLine();


                for (int i=0; i<(pt-pp)*2+4; i++)
                {
                    Console.Write(" ");
                }

                for (int i=0; i<pat.Length; i++)
                {
                    Console.Write(pat[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                count++;

                if (txt[pt] == pat[pp])
                {
                    pt++;
                    pp++;
                }
                else
                {
                    pt = pt - pp + 1;
                    pp = 0;
                }
            }
            Console.WriteLine($"비교는 {count}회였습니다.");
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

            int idx = bfMatch(s1, s2);

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

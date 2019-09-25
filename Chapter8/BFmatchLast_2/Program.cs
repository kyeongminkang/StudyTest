using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFmatchLast_2
{
    class Program
    {
        static int bfMatch(string txt, string pat)
        {
            int pt = txt.Length - 1;
            int pp = pat.Length - 1;

            while (pt >= 0 && pp >= 0)
            {
                if (txt[pt] == pat[pp])
                {
                    pt--;
                    pp--;
                }
                else
                {
                    pt = pt + (pat.Length - pp) - 2;
                    pp = pat.Length - 1;
                }
            }
            if (pp < 0)
                return pt + 1;

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

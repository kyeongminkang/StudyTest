using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("텍스트 : ");
            string s1 = Console.ReadLine();

            Console.Write("패턴 : ");
            string s2 = Console.ReadLine();

            int idx1 = s1.IndexOf(s2);
            int idx2 = s2.IndexOf(s1);

            if (idx1 == -1)
            {
                Console.WriteLine("텍스트 안에 패턴이 없습니다.");

            }
            else
            {
                int len1 = 0;
                for (int i=0; i<idx1; i++)
                {
                    len1 += s1.Substring(i, i + 1).Length;
                }
                len1 += s2.Length;

                int len2 = 0;
                for (int i=0; i<idx2; i++)
                {
                    len2 += s1.Substring(i, i + 1).Length;
                }
                len2 += s2.Length;
            }

            Console.WriteLine("텍스트 : " + s1);
            Console.WriteLine($"패턴 : {s2}");

        }
    }
}

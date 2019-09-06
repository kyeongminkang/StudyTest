using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEqual
{
    class Program
    {
        static Boolean equals(int[]a, int[] b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }

            for (int i=0; i<a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("배열 a의 요솟 수 : ");
            int na = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[na];

            for (int i =0; i< na; i++)
            {
                Console.Write("a[" + i + "] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("배열 b의 요솟 수 : ");
            int nb = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[nb];

            for (int i=0; i< nb; i++)
            {
                Console.Write("b[" + i + "] : ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("배열 a와 b는 " + (equals(a, b) ? "같습니다" : "같지 않습니다"));
        }
    }
}

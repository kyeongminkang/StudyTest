using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudgeSign
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("정수를 입력하세요 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a > 0)
            {
                Console.WriteLine(a + "는 양수입니다.");
            } else if (a < 0)
            {
                Console.WriteLine(a + "는 음수입니다.");
            }else
            {
                Console.WriteLine(a + "는 0입니다.");
            }

        }
    }
}

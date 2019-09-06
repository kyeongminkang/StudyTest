using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMD_11
{
    class Program
    {
        public class YMD_11
        {
            public int y;
            public int m;
            public int d;

            static int[,] mdays = { { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 },
                                { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 },
                               };

            static int isLeap(int year)
            {
                return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? 1 : 0;
            }

            public YMD_11(int y, int m, int d)
            {
                this.y = y;
                this.m = m;
                this.d = d;
            }

            public YMD_11 after(int n)
            {
                YMD_11 temp = new YMD_11(y, m, d);
                if (n < 0)
                {
                    return (before(-n));
                }
                else
                {
                    temp.d += n;
                }

                while (temp.d > mdays[isLeap(temp.y), temp.m - 1])
                {
                    temp.d -= mdays[isLeap(temp.y), temp.m - 1];
                    if (++temp.m > 12)
                    {
                        temp.y++;
                        temp.m = 1;
                    }
                }
                return temp;
            }

            public YMD_11 before(int n)
            {
                YMD_11 temp = new YMD_11(y, m, d);
                if (n < 0)
                {
                    return after(-n);
                }
                else
                {
                    temp.d -= n;
                }

                while (temp.d < 1)
                {
                    if (--temp.m < 1)
                    {
                        temp.y--;
                        temp.m = 12;
                    }
                    temp.d += mdays[isLeap(temp.y), temp.d - 1];
                }

                return temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("날짜를 입력하세요");
            Console.Write("년 : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("월 : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("일 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            YMD_11 date = new YMD_11(year, month, day);

            Console.Write("몇 일 앞/뒤의 날짜를 구할까요? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            YMD_11 d1 = date.after(n);
            Console.WriteLine($"{n}일 뒤의 날짜는 {year}년 {month}월 {day}일 입니다.");

            YMD_11 d2 = date.before(n);
            Console.WriteLine($"{n}일 앞의 날짜는 {year}년 {month}월 {day}일 입니다.");
        }
    }
}

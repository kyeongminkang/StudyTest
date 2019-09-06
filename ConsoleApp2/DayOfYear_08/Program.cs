using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfYear_08
{
    class Program
    {
        static int[,] mdays = {
            { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31},
            { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31},
        };



        static int isLeap(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return 1;
            return 0;   
        }

        static int dayOfYear(int y, int m, int d)
        {
            int[][] a=  new int[3][];
            a[0] = new int[3];
            a[1] = new int[4];
            a[2] = new int[5];

            while (--m != 0)
            {
                
                d += mdays[isLeap(y), m - 1];
            }

            return d;
            
        }
        static void Main(string[] args)
        {
            int retry;

            Console.WriteLine("그 해 경과 일수를 구합니다.");

            do
            {
                Console.Write("년 : ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("월 : ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("일 : ");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("그 해 {0}입니다.\n", dayOfYear(year, month, day));

                Console.Write("한 번 더 할까요? (1.예/0.아니오)");
                retry = Convert.ToInt32(Console.ReadLine());
            } while (retry == 1);
        }
    }
}

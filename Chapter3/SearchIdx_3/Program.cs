﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchIdx_3
{
    class Program
    {
        public static int searchIndx(int[] a, int n, int key, int[] idx)
        {
            int count = 0;
            for(int i=0; i<n; i++)
            {
                if (a[i] == key)
                {

                    idx[count] =i;
                    count++;
                }
            }

            return count;

        }
        static void Main(string[] args)
        {
            Console.Write("요솟수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("검색할 값 : ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] idx = new int[n];
            int num = searchIndx(a, n, key, idx);

            if (num == 0)
            {
                Console.WriteLine("그 값의 요소가 없습니다.");
            }
            else
            {
                //Console.WriteLine(num);
                for (int i = 0; i < num; i++)
                    Console.WriteLine("그 값은 " + "a[" + idx[i] + "]에 있습니다.");


            }

        }
    }
}

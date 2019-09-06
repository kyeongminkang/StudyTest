﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfArrayRand
{
    class Program
    {
        static int maxOf(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {

            Random rnd = new Random();

            Console.WriteLine("키의 최댓값을 구합니다. ");
            Console.Write("사람의 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] height = new int[n];

            Console.WriteLine("키 값은 아래와 같습니다.");
            for (int i = 0; i < n; i++)
            {
                height[i] = rnd.Next(100, 199);
                Console.WriteLine("height[" + i + "] : " + height[i]);
               
            }

            Console.WriteLine("최댓값은 " + maxOf(height) + "입니다.");

        }
    }
}

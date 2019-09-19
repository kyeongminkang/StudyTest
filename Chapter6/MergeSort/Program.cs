using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        private static int[] mBuff;

        private static void __mergeSort(int[]a, int left, int right) // 멤버 함수의 형태라서 __사용함!
        {
            if(left < right)
            {
                int i;
                int center = (left + right) / 2;
                int p = 0;
                int j = 0;
                int k = left;

                __mergeSort(a, left, center);
                __mergeSort(a, center + 1, right);

                for (i=left; i<=center; i++)
                {
                    mBuff[p++] = a[i];
                }

                while (i <= right && j < p)
                {
                    a[k++] = (mBuff[j] <= a[i]) ? mBuff[j++] : a[i++];
                }

                while (j < p)
                    a[k++] = mBuff[j++];
            }
        }

        public static void mergeSort(int[]a, int n)
        {
            mBuff = new int[n];

            __mergeSort(a, 0, n - 1);

            mBuff = null;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("병합 정렬");
            Console.Write("요솟 수 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[a];

            for (int i=0; i<a; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            mergeSort(x, a);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i=0; i< a; i++)
            {
                Console.WriteLine("x[" + i + " ] = " + x[i]);
            }
        }
    }
}

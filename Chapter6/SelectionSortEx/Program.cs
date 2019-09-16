using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortEx
{
    class Program
    {
        static void swap(int[] x, int idx1, int idx2)
        {
            int temp = x[idx1];
            x[idx1] = x[idx2];
            x[idx2] = temp;
        }

        static void selectSort(int[]x, int n)
        {
            
            for(int i=0; i<n-1; i++)
            {
                int temp = i;
                for (int j=i; j<n; j++)
                {
                    if (x[temp] > x[j])
                    {
                        temp = j;
                    }
                        
                }
                swap(x, i, temp);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("단순 선택 정렬 : ");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            selectSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

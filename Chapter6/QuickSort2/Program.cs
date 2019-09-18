using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2
{
    class Program
    {
        static void swap(int[] a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        static void quickSort(int[] a, int left, int right)
        {
            IntStack lStack = new IntStack(right - left + 1);
            IntStack rStack = new IntStack(right - left + 1);

            lStack.push(left);
            rStack.push(right);

            // 안됐던 이유? push 할 때, lStack에서 push후에 ptr을 증가시킴. 그리고 이 증가된 ptr을 가지고 rStack에서 push하기 때문에! 
            // ptr이 static 변수로 해놔서 staic은 계속 올라가 있는 아이라 그랬던 것 같은데 맞는지???

            while (lStack.isEmpty() != true)
            {
                int pl = left = lStack.pop();
                int pr = right = rStack.pop();
                int x = a[(left + right) / 2];

                do
                {
                    while (a[pl] < x) pl++;
                    while (a[pr] > x) pr--;
                    if(pl <= pr)
                    {
                        swap(a, pl++, pr--);
                    }

                } while (pl <= pr);

                if (left < pr)
                {
                    lStack.push(left);
                    rStack.push(pr);
                }
                if (pl < right)
                {
                    lStack.push(pl);
                    rStack.push(right);
                }

            }

           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬(비재귀)");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            quickSort(x, 0, n - 1);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortEx_17
{
    class Program
    {
        public static void swap(int[]a, int idx1, int idx2)
        {
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;
        }

        public static int pow2(int n)
        {
            int k = 1;
            while(n-- > 0)
            {
                k *= 2;
            }
            return k;
        }

        static void dispSpace(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(' ');
        }


        public static void dispHeap(int[]a, int n)
        {
            int i = n;
            int height = 1;
            while ((i >>= 1) > 0)
                height++;
            i = 0;
            int w = 1;
        Loop:
            {
                for (int level = 0; level < height; level++)
                {
                    dispSpace(pow2(height - level) - 3);
                    for (int k = 0; k < w; k++)
                    {
                        Console.Write($"{ a[i++] }");
                        if (i >= n)
                            
                            goto Loop;
                        if (k < w - 1)
                            dispSpace(pow2(height - level + 1) - 2);
                    }
                    Console.WriteLine();

                    dispSpace(pow2(height - level) - 4);
                    for (int k = 0; k < w; k++)
                    {
                        if (2 * k + i < n)
                            Console.Write(" ／ ");
                        if (2 * k + i + 1 < n)
                            Console.Write(" ＼ ");
                        if (k < w - 1)
                            dispSpace(pow2(height - level + 1) - 4);
                    }
                    Console.WriteLine();
                    w *= 2;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        static void downHeap(int[] a, int left, int right)
        {
            int temp = a[left]; // 뿌리
            int child; // 큰 쪽의 자식
            int parent; // 부모

            for (parent = left; parent < (right + 1) / 2; parent = child)
            {
                int cl = parent * 2 + 1; // 왼쪽 자식
                int cr = cl + 1; // 오른쪽 자식
                child = (cr <= right && a[cr] > a[cl]) ? cr : cl; // 큰 쪽
                if (temp >= a[child])
                    break;
                a[parent] = a[child];
            }
            a[parent] = temp;
        }

        // 힙정렬
        static void heapSort(int[] a, int n)
        {
            for (int i = (n - 1) / 2; i >= 0; i--)
            { // a[i]~a[n-1]를 힙으로 만들기
                dispHeap(a, n);
                downHeap(a, i, n - 1);
            }

            for (int i = n - 1; i > 0; i--)
            {
                swap(a, 0, i); // 최대 요소와 아직 미정렬돈 맨끝 요소를 교환
                dispHeap(a, n);
                downHeap(a, 0, i - 1); // a[0]~a[i-1]를 힙으로 만들기
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("힙정렬");
            Console.Write("요솟 수 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "] : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            heapSort(x, n);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }
        }
    }
}

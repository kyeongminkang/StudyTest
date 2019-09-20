using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class program
    {
        static void heapSort(int[] arr)
        {
            int i, temp, length = arr.Length;
            for (i = length / 2 - 1; i >= 0; i--) heapHeapify(arr, length, i);
            for (i = length - 1; i >= 0; i--)
            {
                temp = arr[0]; arr[0] = arr[i]; arr[i] = temp;
                heapHeapify(arr, i, 0);
            }
        }
        static void heapHeapify(int[] arr, int length, int i)
        {
            int left = 2 * i + 1, right = 2 * i + 2;
            int temp, largest = i;
            if (left < length && arr[left] > arr[largest]) largest = left;
            if (right < length && arr[right] > arr[largest]) largest = right;
            if (largest != i)
            {
                temp = arr[i]; arr[i] = arr[largest]; arr[largest] = temp;
                heapHeapify(arr, length, largest);
            }
        }
        static void Main()
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

            heapSort(x);

            Console.WriteLine("오름차순으로 정렬했습니다.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "] = " + x[i]);

            }

      


        }
    }

}


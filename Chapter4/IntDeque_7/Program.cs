using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDeque_7
{
    class Program
    {
        public class IntDeQueue
        {
            private int max;
            private int front;
            private int rear;
            private int num;
            private int[] que;

            public class EmptyQueueExcetion : Exception
            {
                public EmptyQueueExcetion() { }
            }

            public class OverflowIntQueueException : Exception
            {
                public OverflowIntQueueException() { }
            }

            public IntDeQueue(int capacity)
            {
                num = front = rear = 0;
                max = capacity;
                try
                {
                    que = new int[max];
                }
                catch (OutOfMemoryException)
                {
                    max = 0;
                }
            }

            public int enqueFront(int x)
            {
                if (num >= max)
                    throw new OverflowIntQueueException();
                num++;
                if (--front < 0)
                    front = max - 1;
                que[front] = x;
              

                return x;
            }

            public int enqueRear(int x)
            {
                if (num >= max)
                    throw new OverflowIntQueueException();
                que[rear++] = x;
                num++;
                if (rear == max)
                    rear = 0;
                return x;

            }

            public int dequeFront()
            {
                if (num <= 0)
                    throw new EmptyQueueExcetion();
                int x = que[front++];
                num--;
                if (front == max)
                    front = 0;

                return x;
            }

            public int dequeRear()
            {
                if (num <= 0)
                    throw new EmptyQueueExcetion();
                num--;
                if (--rear < 0)
                    rear = max - 1;
                return que[rear];
            }

            public int peekFront()
            {
                if (num <= 0)
                    throw new EmptyQueueExcetion();
                return que[front];
            }

            public int peekRear()
            {
                if (num <= 0)
                    throw new EmptyQueueExcetion();
                return que[rear == 0 ? max - 1 : rear - 1];
            }

            public int indexOf(int x)
            {
                for (int i = 0; i < num; i++)
                {
                    int idx = (i + front) % max;
                    if (que[idx] == x)
                        return idx;
                }

                return -1;
            }

            public void clear()
            {
                num = front = rear = 0;
            }

            public int capacity()
            {
                return max;
            }

            public int size()
            {
                return num;
            }

            public bool isEmpty()
            {
                return num <= 0;
            }

            public bool isFull()
            {
                return num >= max;
            }

            public void dump()
            {
                if (num <= 0)
                    Console.WriteLine("큐가 비어있습니다.");
                else
                {
                    for (int i = 0; i < num; i++)
                        Console.Write(que[(i + front) % max] + " ");
                    Console.WriteLine();
                }
            }

        }
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntQueueTester
{
    class Program
    {
        static void Main(string[] args)
        {
            IntQueue q = new IntQueue(64);

            while (true)
            {
                Console.WriteLine("현재 데이터 수 : " + q.size() + " / " + q.capacity());
                Console.Write("(1) 푸시 (2) 팝 (3) 피크 (4) 덤프 (0) 종료 : ");

                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 0) break;

                int x;
                switch (menu)
                {
                    case 1:
                        Console.Write("데이터 : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            q.enque(x);
                        }
                        catch (IntQueue.OverflowIntQueueException)
                        {
                            Console.WriteLine("큐가 가득찼습니다.");
                        }
                        break;

                    case 2:
                        try
                        {
                            x = q.deque();
                            Console.WriteLine("디큐한 데이터는 " + x + "입니다.");
                        }
                        catch (IntQueue.EmptyQueueExcetion)
                        {
                            Console.WriteLine("큐가 비어 있습니다.");
                        }
                        break;

                    case 3:
                        try
                        {
                            x = q.peek();
                            Console.WriteLine("피크한 데이터는 " + x + "입니다.");
                        }
                        catch (IntQueue.EmptyQueueExcetion)
                        {
                            Console.WriteLine("큐가 비어있습니다.");
                        }
                        break;

                    case 4:
                        q.dump();
                        break;


                }
            }




        }
    }
}

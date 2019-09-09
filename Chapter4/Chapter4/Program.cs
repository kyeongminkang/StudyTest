using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class program
    {
        static void Main(string[] args)
        {
            IntStack s = new IntStack(64);

            while (true)
            {
                Console.WriteLine("현재 데이터 수 : " + s.size() + " / " + s.capacity());
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
                            s.push(x);
                        }catch (IntStack.OverflowIntStackExcption)
                        {
                            Console.WriteLine("스택이 가득찼습니다.");
                        }
                    break;

                    case 2:
                        try
                        {
                            x = s.pop();
                            Console.WriteLine("팝한 데이터는 " + x + "입니다.");
                        }
                        catch (IntStack.EmptyIntStackException)
                        {
                            Console.WriteLine("스택이 비어있습니다.");
                        }
                    break;

                    case 3:
                        try
                        {
                            x = s.peek();
                            Console.WriteLine("피크한 데이터는 " + x + "입니다.");
                        }
                        catch (IntStack.EmptyIntStackException)
                        {
                            Console.WriteLine("스택이 비어있습니다.");
                        }
                    break;

                    case 4:
                        s.dump();
                        break;


                }
            }

            


        }
    }
}

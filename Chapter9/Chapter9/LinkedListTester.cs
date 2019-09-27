using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class LinkedListTester
    {


        public class Data
        {
            public static readonly int NO = 1;
            public static int NAME = 2;

            private int no;
            private string name;
           
            public string toString()
            {
                return "(" + no + ")" + name;
            }

            public void scanData(string guide, int sw)
            {
                Console.WriteLine(guide + "할 데이터를 입력하세요");

                if ((sw & NO) == NO)
                {
                    Console.Write("번호 : ");
                    no = Convert.ToInt32(Console.ReadLine());

                }
                if ((sw & NAME) == NAME)
                {
                    Console.Write("이름 : ");
                    name = Console.ReadLine();
                }
            }

            public static readonly Comparer<Data> NO_ORDER = new NoOrderComparator();

            private class NoOrderComparator : Comparer<Data>
            {

                public override int Compare(Data d1, Data d2)
                {
                    return (d1.no < d2.no) ? 1 : (d1.no < d2.no ) ? -1 : 0;
                }
            }

            public static readonly Comparer<Data> NAME_ORDER = new NameOrderComparator();
            private class NameOrderComparator : Comparer<Data>
            {
                public override int Compare(Data d1, Data d2)
                {
                    return d1.name.CompareTo(d2.name);
                }
            }

        }

        enum Menu
        {
            [Description("머리에 노드를 삽입")]
            ADD_FIRST,

            [Description("꼬리에 노드를 삽입")]
            ADD_LAST,

            [Description("머리 노드를 삭제")]
            RMV_FIRST,

            [Description("꼬리 노드를 삭제")]
            RMV_LAST,

            [Description("선택 노트를 삭제")]
            RMV_CRNT,

            [Description("모든 노드를 삭제")]
            CLEAR,

            [Description("번호로 검색")]
            SEARCH_NO,

            [Description("이름으로 검색")]
            SEARCH_NAME,

            [Description("선택 노드로 이동")]
            NEXT,

            [Description("선택 노드를 출력")]
            PRINT_CRNT,

            [Description("모든 노드를 출력")]
            DUMP,

            [Description("종료")]
            TERMINATE



        }

        private readonly string message;


      

        static Menu? MenuAt(int idx)
        {
            foreach (int m in Enum.GetValues(typeof(Menu)))
            {
                if (m == idx)
                {
                    return (Menu)m;
                }
            }
            return null;
        }

        static Menu SelectMenu()
        {
            int key;
            do
            {
                foreach (int m in Enum.GetValues(typeof(Menu)))
                {
                    Console.WriteLine($"{m}");
                    if ((m % 3) == 2 && m != (int)Menu.TERMINATE)
                    {
                        Console.WriteLine();

                    }
                }
                Console.Write(" : ");
                key = Convert.ToInt32(Console.ReadLine());

            } while (key < (int)Menu.ADD_FIRST || key > (int)Menu.TERMINATE);


            return (Menu)MenuAt(key);
        }





        public static void Main(string[] args)
        {
            Menu menu;
            Data data;
            Data ptr;
            Data temp = new Data();

            LinkedList<Data> list = new LinkedList<Data>();

            do
            {
                switch (menu = SelectMenu())
                {
                    case Menu.ADD_FIRST:
                        data = new Data();
                        data.scanData("머리에 삽입", Data.NO | Data.NAME);
                        list.addFirst(data);
                        break;

                    case Menu.ADD_LAST:
                        data = new Data();
                        data.scanData("꼬리에 삽입", Data.NO | Data.NAME);
                        list.addLast(data);
                        break;

                    case Menu.RMV_FIRST:
                        list.removeFirst();
                        break;

                    case Menu.RMV_LAST:
                        list.removeLast();
                        break;

                    case Menu.RMV_CRNT:
                        list.removeCurrentNode();
                        break;

                    case Menu.SEARCH_NO:
                        temp.scanData("검색", Data.NO);
                        ptr = list.search(temp, Data.NO_ORDER);
                        if (ptr == null)
                            Console.WriteLine("그 번호의 데이터가 없습니다.");
                        else
                            Console.WriteLine("검색 성공 : " + ptr);
                        break;

                    case Menu.SEARCH_NAME:
                        temp.scanData("검색", Data.NAME);
                        ptr = list.search(temp, Data.NAME_ORDER);
                        if (ptr == null)
                            Console.WriteLine("그 이름의 데이터가 없습니다.");
                        else
                            Console.WriteLine("검색 성공 : " + ptr);
                        break;

                    case Menu.NEXT:
                        list.next();
                        break;

                    case Menu.PRINT_CRNT:
                        list.printCurrentNode();
                        break;

                    case Menu.DUMP:
                        list.dump();
                        break;

                    case Menu.CLEAR:
                        list.clear();
                        break;

                    default:
                        Console.WriteLine("모르겠어");
                        break;

                }
            } while (menu != Menu.TERMINATE);
        }
    }
}

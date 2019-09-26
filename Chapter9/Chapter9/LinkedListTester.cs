using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class LinkedListTester
    {


        public class Data
        {
            static readonly int NO = 1;
            static readonly int NAME = 2;

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

            public readonly Comparer<Data> NO_ORDER = new NoOrderComparator();

            private class NoOrderComparator : Comparer<Data>
            {

                public override int Compare(Data d1, Data d2)
                {
                    return d1.name.CompareTo(d2.name);
                }
            }

        }

        enum Menu
        {

            ADD_FIRST
            


        }







        //static void Main(string[] args)
        //    {
        //    }
    }
}

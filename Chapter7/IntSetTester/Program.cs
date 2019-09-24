using Chapter7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntSetTester
{
    class Program
    {
        static void Main(string[] args)
        {
            IntSet s1 = new IntSet(20);
            IntSet s2 = new IntSet(20);
            IntSet s3 = new IntSet(20);

            s1.add(10);
            s1.add(15);
            s1.add(20);
            s1.add(25);

            s1.copyTo(s2);
            s2.add(12);
            s2.remove(25);

            s3.copyFrom(s2);

            Console.WriteLine("s1 = " + s1.toString());
            Console.WriteLine("s2 = " + s2.toString());
            Console.WriteLine("s3 = " + s3.toString());

            Console.WriteLine("집합 s1에 15는 " + (s1.contains(15) ? "포함됩니다." : "포함되지 않습니다."));

            Console.WriteLine("집합 s2에 25는 " + (s2.contains(25) ? "포함됩니다." : "포함되지 않습니다."));

            Console.WriteLine("집합 s1과 s2는 " + (s1.equalTo(s2) ? "같습니다." : "같지 않습니다."));

            Console.WriteLine("집합 s2과 s3는 " + (s2.equalTo(s3) ? "같습니다." : "같지 않습니다."));

            s3.unionOf(s1, s2);

            Console.WriteLine("집합 s1과 s2의 합집합은 " + s3.toString() + "입니다.");

            Console.WriteLine(s1.isFull());
            s1.clear();
            Console.WriteLine(s1.isEmpty());
            Console.WriteLine(s1.toString());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringTester
{

    class A
    {

    }

    public class B
    {
        public int x;

        public B(int x) { this.x = x; }

        public string tostring()
        {
            return "B[" + x + "]";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            B b1 = new B(18);
            B b2 = new B(55);

            Console.WriteLine("a1 = " + a1.ToString());
            Console.WriteLine("a2 = " + a2);
            Console.WriteLine("b1 = " + b1.tostring());
            Console.WriteLine("b2 = " + b2);


        }
    }
}

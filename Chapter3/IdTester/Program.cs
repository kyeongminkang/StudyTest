using System;

namespace IdTester
{
    class Id
    {
        private static int counter = 0;
        private int id;

        public Id() { id = ++counter; }

        public int getId()
        {
            return id;
        }

        public static int getCounter()
        {
            return counter;
        }

        static void Main(string[] args)
        {
            Id a = new Id();
            Id b = new Id();

            Console.WriteLine("a의 아이디 : " + a.getId());
            Console.WriteLine("b의 아이디 : " + b.getId());

            Console.WriteLine("부여한 아이디의 개수 : " + Id.getCounter());
        }
    }
}

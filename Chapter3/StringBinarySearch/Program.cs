using System;

namespace StringBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x =
            {
                "abstract", "assert", "boolean", "break", "byte", "case", "catch", "char", "class", "const", "continue", "default", "do", "double", "else", "enum", "extends", "final", "finally", "float",
                "for", "goto", "if", "implements", "import", "instanceof", "int", "interface", "long", "native", "new", "package", "private", "protected", "public", "return", "short", "static",
                "strictfp", "super", "switch", "synchronized", "this", "throw", "thorws", "transient", "try", "void", "volatile", "while"
            };

            Console.Write("원하는 키워드를 입력하세요 : ");

            string key = Console.ReadLine();

            int idx = Array.BinarySearch(x, key);

            if (idx < 0)
            {
                Console.WriteLine("해당 키워드가 없습니다.");
            }else
            {
                Console.WriteLine("해당 키워드는 x[" + idx + "]에 있습니다.");
            }
        }
    }
}

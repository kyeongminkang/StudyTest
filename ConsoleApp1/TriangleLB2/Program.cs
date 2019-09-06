using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLB2
{
    class Program
    {
        static void triangleLB(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void triangleLU(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
              //for (int j = 1; j <= n - i + 1; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void triangleRU(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
              //for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");

                }
                for (int k = n; k >= i; k--)
              //for (int j = 1; j <= n - 1 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void triangleRB(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
              //for (itn j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
              //for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("몇 단 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //triangleLB(n);
            //triangleLU(n);
            //triangleRU(n);
            triangleRB(n);
        }
    }
}

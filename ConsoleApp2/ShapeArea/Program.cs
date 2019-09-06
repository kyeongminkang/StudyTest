using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Square s = new Square();
            //s.X = 10;
            //s.Y = 20;
            //System.Console.WriteLine(s.GetArea());

            //Circle c = new Circle();
            //c.Radius = 5;
            //System.Console.WriteLine(c.GetArea());

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Square s = new Square();
                s.X = i;
                s.Y = i;

                Circle c = new Circle();
                c.Radius = i;

                shapes.Add(s);
                shapes.Add(c);
            }

            foreach (var shape in shapes)
            {
                if(shape is Square)
                    System.Console.WriteLine($"Square Area: {shape.GetArea()}");
                else if(shape is Circle)
                    System.Console.WriteLine($"Circle Area: {shape.GetArea()}");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            Square s1 = new Square();
            s1.X = 10;
            s1.Y = 20;

            Square s2 = new Square();
            s2 = s1;
            s2.X = 20;

            System.Console.WriteLine();
            System.Console.WriteLine(s1.GetArea());
            System.Console.WriteLine(s2.GetArea());

            int a = 10;
            int b = 0;
            b = a;
            b = 20;
            System.Console.WriteLine($"{a}, {b}");
            System.Console.Write("{0}, {1}", a, b);

        }
    }

}

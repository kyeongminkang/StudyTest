using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Circle : Shape
    {
        public double Radius = 0;
        public double GetArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}

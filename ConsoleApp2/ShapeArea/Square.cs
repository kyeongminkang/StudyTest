﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Square : Shape
    {
        public double X;
        public double Y;
        public double GetArea()
        {
            return X * Y;
        }
    }
}

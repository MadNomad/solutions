using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Figure
    {
        public Figure(Point A, Point B, Point C) { }
        public Figure(Point A, Point B, Point C, Point D) { }
        public Figure(Point A, Point B, Point C, Point D, Point E) { }

        double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return length;
        }
        void PerimeterCalculator() { }
    }
}

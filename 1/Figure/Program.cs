using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1, "A");
            Point b = new Point(2, 2, "B");
            Point c = new Point(3, 2, "C");
            Figure newFigure = new Figure(a, b, c);
        }
    }
}

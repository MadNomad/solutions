using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Figure
    {
        public List<Point> points; 

        public Figure(Point A, Point B, Point C)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            
            PerimeterCalculator(points);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            Point a = A;
            Point b = B;
            Point c = C;
            Point d = D;
            int numOfPoints = 4;
        }


        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Point a = A;
            Point b = B;
            Point c = C;
            Point d = D;
            Point e = E;
            int numOfPoints = 5;
        }

        double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return length;
        }


        void PerimeterCalculator(List<Point> points)
        {
            Console.WriteLine("Точка с координатами X=" + points[0].X + " Y=" + points[0].Y);
        }

    }
}

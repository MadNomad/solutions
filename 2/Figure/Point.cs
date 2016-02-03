using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Point
    {
        // Поля
        public int pointX, pointY;
        public string pointStr;
        //Свойства
        public int X
        {
            get { return pointX; }
        }
        public int Y
        {
            get { return pointY; }
        }
        public string Str
        {
            get { return pointStr; }
        }

        // Конструктор принимающий 3 аргумента
        public Point (int x, int y, string str)
        {
            pointX = x;
            pointY = y;
            pointStr = str;
        }
    }

}

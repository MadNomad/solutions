using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplications.Classes;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
                        new UIHelper().header();
                        new UIHelper().exerciseHeader(2, "Создать класс с именем Rectangle");
                        Rectangle rect = new Rectangle(10,20);
                        rect.AreaCalculator();
                        rect.PerimeterCalculator();
                        Console.WriteLine("Area = " + rect.Area);
                        Console.WriteLine("Perimeter = " + rect.Perimeter);
                        Console.ReadKey();
        }
    }
}

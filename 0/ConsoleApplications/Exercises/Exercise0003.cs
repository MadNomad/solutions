using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Exercise0003
    {
        public void Go()
        {
            string s = Console.ReadLine();

            switch (s)
            {
                case "1":
                    Console.WriteLine("Зима");
                    break;
                case "2":
                    Console.WriteLine("Зима");
                    break;
                case "3":
                    Console.WriteLine("Весна");
                    break;
                case "4":
                    Console.WriteLine("Весна");
                    break;
                case "5":
                    Console.WriteLine("Весна");
                    break;
                case "6":
                    Console.WriteLine("Лето");
                    break;
                case "7":
                    Console.WriteLine("Лето");
                    break;
                case "8":
                    Console.WriteLine("Лето");
                    break;
                case "9":
                    Console.WriteLine("Осень");
                    break;
                case "10":
                    Console.WriteLine("Осень");
                    break;
                case "11":
                    Console.WriteLine("Осень");
                    break;
                case "12":
                    Console.WriteLine("Зима");
                    break;
                default:
                    Console.WriteLine("На этой планете такого месяца нет");
                    break;
            }
        }
    }
}

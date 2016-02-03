using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    public class Exercise0005
    {
        public void Go()
        {
            var n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    Console.WriteLine("Понедельник");
                    break;
                case "2":
                    Console.WriteLine("Вторник");
                    break;
                case "3":
                    Console.WriteLine("Среда");
                    break;
                case "4":
                    Console.WriteLine("Четверг");
                    break;
                case "5":
                    Console.WriteLine("Пятница");
                    break;
                case "6":
                    Console.WriteLine("Суббота");
                    break;
                case "7":
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Нет такого дня");
                    break;
            }
        }
    }
}

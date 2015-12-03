using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    //    Класс определения большего из двух чисел.

    public class Exercise0001
    {
        public void Go()
        {
//            Console.WriteLine("Введите два сравниваемых числа:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}

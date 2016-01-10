using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Проверка является ли число простым. 

    class Exercise0007
    {
        public void Go()
        {
            Console.Write("Введите положительное число: ");
            uint n = Convert.ToUInt16(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine("Введите положительное число");
            if (!(n > 3 && (n % 2 == 0 || n % 3 == 0)))
                Console.WriteLine(n + " является простым числом");
            else
                Console.WriteLine(n + " не является простым числом");
        }
    }
}

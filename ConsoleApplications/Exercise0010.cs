using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Таблица умнодения от 1 до 20 на введенное число N.
    class Exercise0010
    {
        public void Go()
        {
            Console.Write("Введите множитель (целое число): ");
            int x = Convert.ToInt16(Console.ReadLine());
            for (int n = 1; n <= 20; n++)
            {
                Console.WriteLine("{0,4} + {1,-4} = {2,-10}", x, n, x*n);
            }
        }
    }
}

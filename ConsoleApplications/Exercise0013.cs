using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Выведите все точные квадраты натуральных чисел, которые (квадраты) меньше заданного числа N.
    class Exercise0013
    {
        public void Go()
        {
            Console.Write("Задайте диапазон расчета (целое число): ");
            uint max = Convert.ToUInt32(Console.ReadLine());
            int sq =1;
            
            for (int n = 1; sq < max; n++)
            {
                if (!(n > 3 && (n%2 == 0 || n%3 == 0)))
                {
                    sq = n * n;
                    if (sq < max)
                        Console.WriteLine(sq);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Класс рачета стоимости поездки.

    class Exercise0006
    {
        public void Go()
        {
            const int costFist5Km = 20;
            const int costKm = 3;
            const int costMin = 1;
            double totalCost = 0;

            Console.Write("Введите длинну маршрута (км): ");
            double lenght = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длительность простоя (мин): ");
            double wait = Convert.ToDouble(Console.ReadLine());

            if (lenght <= 5)
            {
                totalCost = costFist5Km + wait*costMin;
            }
            else
            {
                totalCost = costFist5Km + (lenght - 5)*costKm + wait*costMin;
            }

            Console.WriteLine("Итого к оплате: " + totalCost);
        }
    }
}

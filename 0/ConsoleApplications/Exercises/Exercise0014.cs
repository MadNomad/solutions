using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Прочитать с клавиатуры 5 целых чисел, посчитать их среднее арифметическое и сообщить его пользователю.
    class Exercise0014
    {
        public void Go()
        {
            Console.WriteLine("Введите 5 целых чисел");
            int sum = 0;
            for (int n = 0; n < 5; n++)
            {
                sum = sum + Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Среднее арифметическое введенных чисел " + sum/5);
        }
    }
}

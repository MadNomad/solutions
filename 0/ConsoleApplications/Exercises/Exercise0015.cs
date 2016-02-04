using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Создать 5 случайных целых чисел, посчитать их среднее арифметическое и сообщить его пользователю.
    class Exercise0015
    {
        public void Go()
        {
            Console.WriteLine("Придумываю 5 целых чисел.... ммм...");
            int sum = 0;
            Random num = new Random();
            for (int n = 0; n < 5; n++)
            {
                int tmp = Convert.ToInt16(num.Next(1, 100));
                Console.WriteLine(tmp);
                sum += tmp;
            }
            Console.WriteLine("Среднее арифметическое задуманых чисел " + sum / 5);

        }
    }
}

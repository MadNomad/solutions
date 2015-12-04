using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Игра: Угадай число.
    class Exercise0012
    {
        public void Go()
        {
            Console.WriteLine("Ммм.... загадал число от 1 до 146! Угадывай! :-)");
            int num = new Random().Next(1, 146);
            bool gotcha = false;
            while (gotcha == false)
            {
                gotcha = UserAnswer(num);
            }
            Console.WriteLine("Угадал! Я загадал " + num);
        }

        private bool UserAnswer(int num)
        {
            int userNum = Convert.ToInt16(Console.ReadLine());
            if (userNum > num)
            {
                Console.WriteLine("Меньше");
                return false;
            }
            else if (userNum < num)
            {
                Console.WriteLine("Больше");
                return false;
            }
            else
                return true;
        }
    }
}

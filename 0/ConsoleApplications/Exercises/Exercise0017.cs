using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
//    Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор,
//    пока он не будет введен. Правильный пароль пусть будет «root». Если пароль не
//    верный, программа должна сказать "Неверный пароль!"
    class Exercise0017
    {
        public void Go()
        {
            string pass = "root";
            bool access = false;
            while (access != true)
            {
                Console.Write("Введите пароль: ");
                string input = Console.ReadLine();
                if (input.Equals(pass))
                    access = true;
                else
                    Console.WriteLine("Неверный пароль!");
            }
        }
    }
}

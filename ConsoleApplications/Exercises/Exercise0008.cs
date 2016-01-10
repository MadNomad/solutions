using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Exercise0008
    {
        public void Go()
        {
            int result = 0;
            Console.Write("Введите вашу ставку: ");
            int bet = Convert.ToInt16(Console.ReadLine());
            int dice = new Random().Next(1,12);
            if (dice <= 5)
                result = 0;
            else if (dice >= 6 && dice <= 8)
                result = bet;
            else if (dice >= 9 && dice <= 11)
                result = bet*2;
            else if (dice == 12)
                result = bet*10;
            else
                Console.WriteLine("Беда! Сильно кубик кинули... улетел куда-то...");
            
            Console.WriteLine("Выпало число " + dice +". Выигрыш составил: " + result + " тугриков");
        }
    }
}

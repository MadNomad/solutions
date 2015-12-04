using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все сочетания)?
    class Exercise0016
    {
        public void Go()
        {
            int summary = 64;
            int krol = 0;
            int guss = 0;
            for (int i = 64; i >= 0; i = i - 4)
            {
                krol = i/4;
                guss = (summary - i)/2;
                Console.WriteLine("Если кроликов " + krol + ", тогда гусей " + guss);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Нахождение и вывод количества разрядом в введенном числе.
    class Exercise0011
    {
        public void Go()
        {
            Console.Write("Введите число: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToInt16(BigInteger.Log10(n)));
        }
    }
}

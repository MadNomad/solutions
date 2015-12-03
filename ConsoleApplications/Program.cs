using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameLast = "Ермолов";
            string nameFist = "Сергей";
            string nameMiddle = "Александрович";

            Console.Write(nameLast + " " + nameFist + " " + nameMiddle);
            Console.WriteLine();
            Console.ReadKey();

           Exercise0009 test = new Exercise0009();
            test.Go();
            Console.ReadKey();
        }
    }
}

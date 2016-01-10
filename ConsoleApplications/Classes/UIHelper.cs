using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications.Classes
{
    public class UIHelper
    {
        public void header()
        {
            const string nameLast = "Ермолов";
            const string nameFist = "Сергей";
            const string nameMiddle = "Александрович";

            Console.Write(nameLast + " " + nameFist + " " + nameMiddle);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("<< Press any key >>");
            Console.ReadKey();
            Console.Clear();
        }


        public void exerciseHeader(int num, string text)
        {
            Console.WriteLine("Задание " + num);
            Console.WriteLine("Требуется: " + text);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplications.Classes;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
                        new UIHelper().header();
                        new UIHelper().exerciseHeader(1, "Создать класс с именем Address");
                        Address adr = new Address();
                        adr.index = 49000;
                        adr.country = "Ukraine";
                        adr.city = "Dniepropetrovsk";
                        adr.street = "Troicka St.";
                        adr.house = "3A";
                        adr.apartment = "13";
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", adr.index.ToString(), adr.country, adr.city, adr.street, adr.house, adr.apartment);
                        Console.ReadKey();
        }
    }
}

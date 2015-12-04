using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    // Класс перевода из одной валюты в другую.
    class Exercise0009
    {
        public void Go()
        {
            //double kursEUR = 1; 
            double kursUSD = 1.15; 
            double kursUAH = 28; 
            Console.Clear();
            Console.Write("Введите сумму: ");
            double totalMoney = Convert.ToDouble(Console.ReadLine());

            string currency = null;
            while (currency == null)
            {
                currency = ChangeCurrency();
            }

            Console.Clear();
            Console.WriteLine(totalMoney + " " + currency + " соответствует:");

            switch (currency)
            {
                case "UAH":
                    double uahusd = totalMoney/kursUAH*kursUSD;
                    double uaheur = totalMoney/kursUAH;
                    Console.WriteLine(uahusd + " USD");
                    Console.WriteLine(uaheur + " EUR");
                    break;
                case "USD":
                    double usduah = totalMoney / kursUSD * kursUAH;
                    double usdeur = totalMoney / kursUSD;
                    Console.WriteLine(usduah + " UAH");
                    Console.WriteLine(usdeur + " EUR");
                    break;
                case "EUR":
                    double euruah = totalMoney * kursUAH;
                    double eurusd = totalMoney * kursUSD;
                    Console.WriteLine(euruah + " UAH");
                    Console.WriteLine(eurusd + " USD");
                    break;
                default:
                    Console.WriteLine(currency + " это что-то новенькое! Не слыхивал! :-)");
                    break;
            }

        }

        string ChangeCurrency()
        {
            Console.Clear();
            Console.WriteLine("Укажите исходную вылюту:");
            Console.WriteLine();
            Console.WriteLine("1: UAH");
            Console.WriteLine("2: USD");
            Console.WriteLine("3: EUR");
            Console.WriteLine();
            string currency = Console.ReadLine();

            switch (currency)
            {
                case "1":
                    return "UAH";
                case "2":
                    return "USD";
                case "3":
                    return "EUR";
                default:
                    return null;
            }
        }
    }
}

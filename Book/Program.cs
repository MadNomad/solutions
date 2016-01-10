using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Three on the boat, exclude the Dog", "Jerome K. Jerome", "Awesome comedy story");
            book1.Show();
            Console.ReadKey();
        }
    }
}

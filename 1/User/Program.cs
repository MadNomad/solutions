using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("test_user", "Thomas", "Amnet", 23);
            user1.ShowInfo();
            Console.ReadKey();
        }
    }
}

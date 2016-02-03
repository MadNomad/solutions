using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApplications.Classes;

namespace ConsoleApplications
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Exercise0003 test = new Exercise0003();
            test.Go();
            Console.ReadKey();
        }
    }
}
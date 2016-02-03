using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
        	Employee newMan = new Employee("Thomas", "Amnet");
        	newMan.Salary();
        	
        	Console.ReadKey();
        }
    }
}

/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.01.2016
 * Time: 12:55
 */
using System;

namespace Calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine(Calc.Addition(3,3));
			Console.WriteLine(Calc.Subtraction(3,3));
			Console.WriteLine(Calc.Multiplication(3,3));
			Console.WriteLine(Calc.Division(3,3));
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
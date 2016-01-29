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
			
			Calc.Summ(3,3);
			Calc.Razn(3,3);
			Calc.Umn(3,3);
			Calc.Delen(3,3);
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
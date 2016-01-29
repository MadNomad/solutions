/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.01.2016
 * Time: 15:10
 */
using System;

namespace Calculator
{
	/// <summary>
	/// Description of Calc.
	/// </summary>
	public static class Calc
	{
		static double var1, var2;
		
		public static void Summ (double var1, double var2)
		{
			Console.WriteLine("{0} + {1} = " + (var1 + var2), var1, var2);
		}

		public static void Razn (double var1, double var2)
		{
			Console.WriteLine("{0} - {1} = " + (var1 - var2), var1, var2);
		}

		public static void Umn (double var1, double var2)
		{
			Console.WriteLine("{0} * {1} = " + (var1 * var2), var1, var2);
		}

		public static void Delen (double var1, double var2)
		{
			Console.WriteLine("{0} / {1} = " + (var1 / var2), var1, var2);
		}
	}
}

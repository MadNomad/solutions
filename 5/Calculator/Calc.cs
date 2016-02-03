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
		public static double Addition (double var1, double var2)
		{
			return (var1 + var2);
		}

		public static double Subtraction (double var1, double var2)
		{
			return (var1 - var2);
		}

		public static double Multiplication (double var1, double var2)
		{
			return (var1 * var2);
		}

		public static double Division (double var1, double var2)
		{
			return (var1 / var2);
		}
	}
}

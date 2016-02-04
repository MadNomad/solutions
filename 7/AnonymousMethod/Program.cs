/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.02.2016
 * Time: 12:21
 */
using System;

namespace AnonymousMethod
{
	class Program
	{
		public static void Main(string[] args)
		{			
			Average myDelegate = delegate(int a, int b, int c) {return (a + b + c)/3;};
			
			// Nums for test
			a = 3;
			b = 4;
			c = 5;
			
			Console.WriteLine("Average of {0}, {1} and {2} is {3}", a, b, c, myDelegate(a, b, c));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public delegate int Average(int a, int b, int c);
	}
}
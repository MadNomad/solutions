/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.02.2016
 * Time: 12:44
 */
using System;

namespace Lambda
{
	class Program
	{
		public static void Main(string[] args)
		{
			MathReturn myAdd = (a, b) => {return a + b;}; // Оператор сложения
			MathReturn mySub = (a, b) => {return a - b;}; // Оператор вычитания
			MathReturn myMul = (a, b) => {return a * b;}; // Оператор умножения
			MathReturn myDiv = (a, b) => {if (b != 0) {return a / b;} else {throw new DivideByZeroException();}}; // Оператор деления
			
			myAdd(1,2);
			mySub(3,2);
			myMul(3,3);
			myDiv(6,2);
//			myDiv(3,0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public delegate double MathReturn(double a, double b);
	}
}
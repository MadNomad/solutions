/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.01.2016
 * Time: 18:27
 */
using System;

namespace Printer
{
	/// <summary>
	/// Description of Printer.
	/// </summary>
	public class Printer
	{
		public  void Print (string msg)
		{
			Console.WriteLine (msg);
		}
	}
	
	public class ColorPrinter : Printer
	{
		public  void Print(string msg)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine (msg);
			Console.ResetColor();
		}
	}
}

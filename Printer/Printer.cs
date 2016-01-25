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
		public virtual void Print (string value)
		{
			Console.WriteLine (value);
		}
	}
	
	public class ColorPrinter : Printer
	{
		public override void Print(string value)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine (value);
			Console.ResetColor();
		}
	}
}

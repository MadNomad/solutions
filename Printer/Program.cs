/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.01.2016
 * Time: 18:24
 */
using System;

namespace Printer
{
	class Program
	{
		public static void Main()
		{
			string message = "Hello World!";
			
			Printer newPrint = new Printer();
			newPrint.Print(message);
			
			ColorPrinter colorPrint = newPrint as ColorPrinter;
			colorPrint.Print(message);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
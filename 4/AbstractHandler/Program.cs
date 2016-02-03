/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 27.01.2016
 * Time: 15:53
 */
using System;

namespace AbstractHandler.Classes
{
	class Program
	{
		public static void Main(string[] args)
		{
			AbstractHandler newFile;
			newFile.fileName = "bla-bla-bla.txt";
			newFile = newFile.getHandler();

			newFile.Create;
			newFile.Chenge;
			newFile.Save;
			newFile.Open;
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
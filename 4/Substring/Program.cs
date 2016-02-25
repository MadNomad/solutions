/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 01.02.2016
 * Time: 17:16
 */
using System;

namespace Substring
{
	class Program
	{
		public static void Main(string[] args)
		{
			string testString = "Cool Class!";
			
			Console.WriteLine(testString.MySubstring(5, 9));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
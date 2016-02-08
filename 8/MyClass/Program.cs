/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.02.2016
 * Time: 14:47
 */
using System;

namespace MyClass
{
	class Program
	{
		public static void Main(string[] args)
		{
			MyClass<string> test = new MyClass<string>();
//			MyClass<int> test1 = MyClass<int>.FacrotyMethod();
//			stringTest
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
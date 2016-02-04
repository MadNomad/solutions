/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.02.2016
 * Time: 14:38
 */
using System;
using System.Collections.Generic;

namespace AnonymousMethodExt
{
	class Program
	{
		public static void Main(string[] args)
		{
			MyDelegate quickRnd = new MyDelegate(RndInt.Next());
			List<MyDelegate> delegates = new List<MyDelegate>();
			for (int i = 0; i < 10; i++) {
				delegates.Add(new quickRnd());
			}
			int summ;
			MyAverage average = delegate(delegates)
			{
				foreach (MyDelegate item in delegates)
				{
					summ += item;
				}
				return summ;
			};
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	#region Kitchen
	public static class RndInt
	{
		public static int Next()
		{
			Random rnd = new Random();
			return Convert.ToInt16(rnd.Next());
		}
	}

	public delegate int MyDelegate();
		
	public delegate int MyAverage(List<MyDelegate> delegates);

	#endregion
}
/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 02.02.2016
 * Time: 11:09
 */
using System;
using System.Collections.Generic;

namespace Notebook
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<Item> database = new List<Item>();
			database.Add(new Item("G550", "Lenovo", 440));
			database.Add(new Item("G560", "Lenovo", 540));
			database.Add(new Item("G580", "Lenovo", 640));
			database.Add(new Item("Y560", "Lenovo", 840));
			database.Add(new Item("Y580", "Lenovo", 940));
			
			foreach(Item item in database)
			{
				item.Show();
			}
			
			Console.WriteLine("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
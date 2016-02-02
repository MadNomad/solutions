/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 02.02.2016
 * Time: 15:34
 */
using System;
using System.Collections.Generic;

namespace Train
{
	/// <summary>
	/// Description of UIHelper.
	/// </summary>
	public static class UIHelper
	{
		public static void Table (List<Train> database, int getItem = 0)
		{
			Console.Clear();
			Console.WriteLine("   -----------------------------------------------------------------------");
			Console.WriteLine("\tTrain number\t\tDestination\t\tDeparture time");
			Console.WriteLine("   -----------------------------------------------------------------------");
			Console.WriteLine("\n\n");
			
			if (database.Count == 0) {
				Console.WriteLine("\t\t\t    No trains in DataBase");
			}
			else if (getItem != 0)
			{
				database.Find(x => x.trainNum.Equals(getItem)).Show();
			}
			else 
			{
				database.Sort();
				foreach (var item in database) {
					item.Show();
				}
			}

			Console.WriteLine("\n\n");
			Console.WriteLine("   -----------------------------------------------------------------------");
			Console.WriteLine("\n\n");
			Break();
		}
		
		public static void Menu()
		{
			Console.Clear();
			Console.WriteLine("   -----------------------------------------------------------------------");
			Console.WriteLine("\n\n");
			Console.WriteLine("   1. Display all trains");
			Console.WriteLine("   2. View needed train");
			Console.WriteLine("   3. Add train to DataBase");
			Console.WriteLine("\n\n");
			Console.WriteLine("   0. Exit");
			Console.WriteLine("\n\n");
			Console.WriteLine("   -----------------------------------------------------------------------");
			Console.WriteLine("\n\n");
		}

		public static void Break()
		{
			Console.WriteLine("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int GetInt()
		{
			try
			{
				return int.Parse(Console.ReadLine().Trim());
			}
			catch (Exception e)
			{
				Console.WriteLine(string.Format("{0} Попробуйте еще раз...", e.Message));
				return GetInt();
			}
		}
	}
}

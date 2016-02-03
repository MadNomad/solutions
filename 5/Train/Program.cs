/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 02.02.2016
 * Time: 14:55
 */
using System;
using System.Collections.Generic;

namespace Train
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<Train> database = new List<Train>();
			
			bool active = true;
			while (active) {
				UIHelper.Menu();
				int userChoise = UIHelper.GetInt();
				switch (userChoise) {
					case 1:
						TableAll(database);
						break;
					case 2:
						Console.Write("   Enter train <number>: ");
						TableItem(database, UIHelper.GetInt());
						break;
					case 3:
						Console.Write("   Enter train's <number>: ");
						int trainNum = UIHelper.GetInt();
						Console.Write("   Enter train's <destination>: ");
						string trainDest = Console.ReadLine();
						Console.Write("   Enter train's <departure date>: ");
						DateTime trainDate;
						DateTime.TryParse(Console.ReadLine(), out trainDate);
						database.Add(new Train(trainNum, trainDest, trainDate));
						break;
					case 0:
					default:
						active = false;
						break;
				}
			}
		}
		
		public static void TableAll(List<Train> database)
		{
			UIHelper.Header();
			if (database.Count == 0) {
				Console.WriteLine("\t\t\t    No trains in DataBase");
			} else {
				database.Sort();
				foreach (var item in database) {
					item.Show();
				}
			}
			UIHelper.Footer();
		}
		
		public static void TableItem(List<Train> database, int getItem)
		{
			List<Train> trains = database.FindAll(x => x.trainNum.Equals(getItem));
			UIHelper.Header();
			if (trains.Count > 0) {
				foreach (var item in trains) {
					item.Show();
				}
			} else {
				Console.WriteLine("\t\t\t    No trains in DataBase");
			}
			UIHelper.Footer();
		}
		
	}
}
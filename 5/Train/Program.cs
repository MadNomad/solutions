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
						UIHelper.Table(database);
						break;
					case 2:
						Console.Write("   Enter train <number>: ");
						UIHelper.Table(database, UIHelper.GetInt());
						break;
					case 3:
						Console.Write("   Enter train's <number>: ");
						int trainNum = UIHelper.GetInt();
						Console.Write("   Enter train's <destination>: ");
						string trainDest = Console.ReadLine();
						Console.Write("   Enter train's <departure date>: ");
						DateTime trainDate;
						DateTime.TryParse(Console.ReadLine(), trainDate);
						database.Add(new Train(trainNum, trainDest, trainDate));
						break;
					case 0:
					default:
						active = false;
						break;
				}
			}
		}
	}
}
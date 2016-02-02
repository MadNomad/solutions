/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 02.02.2016
 * Time: 14:55
 */
using System;

namespace Train
{
	/// <summary>
	/// Description of Train.
	/// </summary>
	public struct Train : IComparable<Train>
	{
		public int trainNum;
		string trainPointName;
		DateTime trainStartDate;
		
		public Train (int number, string point, DateTime date)
		{
			this.trainNum = number;
			this.trainPointName = point;
			this.trainStartDate = date;
		}
		
		public void Show()
		{
			if (trainNum != 0)
			{
				Console.WriteLine("\t  {0}\t\t\t{1}\t\t\t{2}", trainNum, trainPointName, trainStartDate.ToString("d MMM yyyy"));
			}
			else
			{
				Console.WriteLine("\t\t\t    No trains in DataBase");
				
			}
		}
		
		#region IComparable implementation
		public int CompareTo(Train other)
		{
           if (this.trainStartDate > other.trainStartDate)
                return 1;
            if (this.trainStartDate < other.trainStartDate)
                return -1;
            else
                return 0;
  		}
		#endregion
	}
}

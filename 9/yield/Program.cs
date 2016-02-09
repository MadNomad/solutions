/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 09.02.2016
 * Time: 13:49
 */
using System;
using System.Collections.Generic;

namespace yield
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> collection = new List<int>();
			int[] newArray = { 2, 5, 56, 1, 6, 10 };
			collection = Even(newArray);
			foreach (var element in collection) {
				Console.WriteLine(element);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static List<int> Even (int[] arr)
		{
			List<int> newlist = new List<int>();
			for (int i = 0; i < arr.Length; i++) {
				if (arr[i] % 2 == 0)
				{
					newlist.Add(arr[i]);
				}
			}
			return newlist;
		}
	}
}
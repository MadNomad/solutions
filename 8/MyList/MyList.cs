/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.02.2016
 * Time: 16:11
 */
using System;

namespace MyList
{
	/// <summary>
	/// Description of MyList.
	/// </summary>
	public class MyList<T>
	{
		private T[] list;
		private int count;
		
		public int Count {
			public get {
				foreach (var element in list) {
					this.count++;
				} 
				return this.count;
			}
		}
		
		public static void Add(T item)
		{
			list += item;
		}
		
		public object this [int pos]
		{
			get {
				int i = 0;
				foreach (var element in list) {
					if (i == pos)
					{
						return element;
					}
				}

			}
		}
	}
}

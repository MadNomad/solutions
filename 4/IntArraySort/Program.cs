/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 01.02.2016
 * Time: 12:19
 */
using System;

namespace IntArraySort
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] newArray = { 16, 21, 31, 3, 28, 3, 42, 18, 12, 7, 2, 4, 6, 8 };

			Console.WriteLine("Сортировка массива целых чисел\n");
			newArray.ArraySort();
			foreach (var item in newArray) {
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("А теперь сортировка в обратном порядке. Жмем кнопку . . . ");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("Сортировка массива целых чисел по убыванию\n");
			newArray.ArraySortDesc(true);
			foreach (var item in newArray) {
				Console.WriteLine(item);
			}
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
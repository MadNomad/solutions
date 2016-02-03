/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 02.02.2016
 * Time: 11:20
 */
using System;

namespace Notebook
{
	/// <summary>
	/// Создайте структуру с именем - Notebook.
	/// Поля структуры: модель, производитель, цена.
	/// В структуре должен быть реализован конструктор для инициализации полей
	/// </summary>
	public struct Item
	{
		public string model;
		public string manufacturer;
		public double price;

		public Item (string model, string manufacturer, double price)
		{
			this.model = model;
			this.manufacturer = manufacturer;
			this.price = price;
		}
		
		public void Show()
        {
            Console.WriteLine("{0}\t\t{1}\t\t\t{2}$", manufacturer, model, price);
        }

	}
}

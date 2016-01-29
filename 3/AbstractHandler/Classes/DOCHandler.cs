/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 27.01.2016
 * Time: 16:08
 */
using System;

namespace AbstractHandler.Classes
{
	/// <summary>
	/// Description of DOCHandler.
	/// </summary>
	public class DOCHandler : AbstractHandler
	{
		void Open()
		{
			Console.WriteLine ("Открываем файл .DOC");
		}
		
		void Create()
		{
			Console.WriteLine ("Создаем файл .DOC");
		}
		
		void Chenge()
		{
			Console.WriteLine ("Изменяем файл .DOC");
		}
		
		void Save()
		{
			Console.WriteLine ("Сохраняем файл .DOC");
		}
	}
}

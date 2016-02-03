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
	/// Description of XMLHandler.
	/// </summary>
	public class XMLHandler : AbstractHandler
	{
		void Open()
		{
			Console.WriteLine ("Открываем файл .XML");
		}
		
		void Create()
		{
			Console.WriteLine ("Создаем файл .XML");
		}
		
		void Chenge()
		{
			Console.WriteLine ("Изменяем файл .XML");
		}
		
		void Save()
		{
			Console.WriteLine ("Сохраняем файл .XML");
		}
	}
}

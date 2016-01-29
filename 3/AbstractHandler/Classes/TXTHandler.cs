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
	/// Description of TXTHandler.
	/// </summary>
	public class TXTHandler : AbstractHandler
	{
		void Open()
		{
			Console.WriteLine ("Открываем файл .TXT");
		}
		
		void Create()
		{
			Console.WriteLine ("Создаем файл .TXT");
		}
		
		void Chenge()
		{
			Console.WriteLine ("Изменяем файл .TXT");
		}
		
		void Save()
		{
			Console.WriteLine ("Сохраняем файл .TXT");
		}
	}
}
